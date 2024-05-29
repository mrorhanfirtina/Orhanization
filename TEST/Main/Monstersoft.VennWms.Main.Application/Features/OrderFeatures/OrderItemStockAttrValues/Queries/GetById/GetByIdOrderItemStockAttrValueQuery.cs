using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants.OrderItemStockAttrValueOperationClaims;
using Monstersoft.VennWms.Main.Application.Statics;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Queries.GetById;

public class GetByIdOrderItemStockAttrValueQuery : IRequest<GetByIdOrderItemStockAttrValueResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public OrderItemStockAttrValueDetailLevel DetailLevel { get; set; }


    public class GetByIdOrderItemStockAttrValueQueryHandler : IRequestHandler<GetByIdOrderItemStockAttrValueQuery, GetByIdOrderItemStockAttrValueResponse>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdOrderItemStockAttrValueQueryHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, IMapper mapper, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _mapper = mapper;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
        }

        public async Task<GetByIdOrderItemStockAttrValueResponse> Handle(GetByIdOrderItemStockAttrValueQuery request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdOrderItemStockAttrValueResponse>(await _orderItemStockAttrValueRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<OrderItemStockAttrValue> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeOrderItem)
                    {
                        query = query.Include(y => y.OrderItem);

                        if (detailLevel.OrderItemDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(y => y.Product);
                        }

                        if (detailLevel.OrderItemDetailLevel.IncludeOrder)
                        {
                            query = query.Include(y => y.OrderItem).ThenInclude(y => y.Order);
                        }
                    }

                    if (detailLevel.IncludeStockAttribute)
                    {
                        query = query.Include(y => y.StockAttribute);

                        if (detailLevel.StockAttributeDetailLevel.IncludeAttributeInputType)
                        {
                            query = query.Include(y => y.StockAttribute).ThenInclude(y => y.AttributeInputType);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<OrderItemStockAttrValue, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdOrderItemStockAttrValueResponse>(await _orderItemStockAttrValueRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }

}
