using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Constants.OrderTypeOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetById;

public class GetByIdOrderTypeQuery : IRequest<GetByIdOrderTypeResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderTypeDetailLevel DetailLevel { get; set; }



    public class GetByIdOrderTypeQueryHandler : IRequestHandler<GetByIdOrderTypeQuery, GetByIdOrderTypeResponse>
    {
        private readonly IOrderTypeRepository _orderTypeRepository;
        private readonly OrderTypeBusinessRules _orderTypeBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderTypeQueryHandler(IOrderTypeRepository orderTypeRepository, IMapper mapper, OrderTypeBusinessRules orderTypeBusinessRules)
        {
            _orderTypeRepository = orderTypeRepository;
            _mapper = mapper;
            _orderTypeBusinessRules = orderTypeBusinessRules;
        }

        public async Task<GetByIdOrderTypeResponse> Handle(GetByIdOrderTypeQuery request, CancellationToken cancellationToken)
        {
            _orderTypeBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderTypeResponse>(await _orderTypeRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<OrderType> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Orders);

                        if (detailLevel.OrderDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Depositor);
                        }

                        if (detailLevel.OrderDetailLevel.IncludeCustomer)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Customer);
                        }

                        if (detailLevel.OrderDetailLevel.IncludeReceiver)
                        {
                            query = query.Include(y => y.Orders).ThenInclude(y => y.Receiver);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderType, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderTypeResponse>(await _orderTypeRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
