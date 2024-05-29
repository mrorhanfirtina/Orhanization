using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants.OrderPriorityOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Queries.GetById;

public class GetByIdOrderPriorityQuery : IRequest<GetByIdOrderPriorityResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderPriorityDetailLevel DetailLevel { get; set; }

    public class GetByIdOrderPriorityQueryHandler : IRequestHandler<GetByIdOrderPriorityQuery, GetByIdOrderPriorityResponse>
    {
        private readonly IOrderPriorityRepository _orderPriorityRepository;
        private readonly OrderPriorityBusinessRules _orderPriorityBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderPriorityQueryHandler(IOrderPriorityRepository orderPriorityRepository, IMapper mapper, OrderPriorityBusinessRules orderPriorityBusinessRules)
        {
            _orderPriorityRepository = orderPriorityRepository;
            _mapper = mapper;
            _orderPriorityBusinessRules = orderPriorityBusinessRules;
        }

        public async Task<GetByIdOrderPriorityResponse> Handle(GetByIdOrderPriorityQuery request, CancellationToken cancellationToken)
        {
            _orderPriorityBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderPriorityResponse>(await _orderPriorityRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<OrderPriority> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludePriorityList)
                    {
                        query = query.Include(y => y.Priority);
                    }


                    var includableQuery = query as IIncludableQueryable<OrderPriority, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderPriorityResponse>(await _orderPriorityRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}


