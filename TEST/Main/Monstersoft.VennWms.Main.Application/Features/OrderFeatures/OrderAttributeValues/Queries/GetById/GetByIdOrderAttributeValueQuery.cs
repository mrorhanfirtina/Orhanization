using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Constants.OrderAttributeValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;

public class GetByIdOrderAttributeValueQuery : IRequest<GetByIdOrderAttributeValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderAttributeValueDetailLevel DetailLevel { get; set; }



    public class GetByIdOrderAttributeValueQueryHandler : IRequestHandler<GetByIdOrderAttributeValueQuery, GetByIdOrderAttributeValueResponse>
    {
        private readonly IOrderAttributeValueRepository _orderAttributeValueRepository;
        private readonly OrderAttributeValueBusinessRules _orderAttributeValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderAttributeValueQueryHandler(IOrderAttributeValueRepository orderAttributeValueRepository, IMapper mapper, OrderAttributeValueBusinessRules orderAttributeValueBusinessRules)
        {
            _orderAttributeValueRepository = orderAttributeValueRepository;
            _mapper = mapper;
            _orderAttributeValueBusinessRules = orderAttributeValueBusinessRules;
        }

        public async Task<GetByIdOrderAttributeValueResponse> Handle(GetByIdOrderAttributeValueQuery request, CancellationToken cancellationToken)
        {
            _orderAttributeValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderAttributeValueResponse>(await _orderAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<OrderAttributeValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrder)
                    {
                        query = query.Include(y => y.Order);
                    }

                    if (detailLevel.IncludeOrderAttribute)
                    {
                        query = query.Include(y => y.OrderAttribute);

                        if (detailLevel.OrderAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.OrderAttribute).ThenInclude(m => m.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderAttributeValue, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderAttributeValueResponse>(await _orderAttributeValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
