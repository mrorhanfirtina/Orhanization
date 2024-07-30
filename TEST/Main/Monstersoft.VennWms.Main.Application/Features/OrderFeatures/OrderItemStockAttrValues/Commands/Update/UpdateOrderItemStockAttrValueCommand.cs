using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants.OrderItemStockAttrValueOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Update;

public class UpdateOrderItemStockAttrValueCommand : IRequest<UpdatedOrderItemStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderItemStockAttrValueOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItemStockAttrValues"];

    public UpdateOrderItemStockAttrValueDto OrderItemStockAttrValue { get; set; }
    public OrderItemStockAttrValuesDetailLevel DetailLevel { get; set; }


    public class UpdateOrderItemStockAttrValueCommandHandler : IRequestHandler<UpdateOrderItemStockAttrValueCommand, UpdatedOrderItemStockAttrValueResponse>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public UpdateOrderItemStockAttrValueCommandHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules, IMapper mapper)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedOrderItemStockAttrValueResponse> Handle(UpdateOrderItemStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderItemStockAttrValue.Id)
            .CheckOrderItemIdExistence(request.OrderItemStockAttrValue.OrderItemId)
            .CheckStockAttributeIdExistence(request.OrderItemStockAttrValue.StockAttributeId);

            OrderItemStockAttrValue? currentOrderItemStockAttrValue = await _orderItemStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.OrderItemStockAttrValue.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            OrderItemStockAttrValue? orderItemStockAttrValue = _mapper.Map(request.OrderItemStockAttrValue, currentOrderItemStockAttrValue);
            orderItemStockAttrValue.UpdatedDate = DateTime.Now;

            await _orderItemStockAttrValueRepository.UpdateAsync(orderItemStockAttrValue);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _orderItemStockAttrValueRepository.GetAsync(predicate: x => x.Id == orderItemStockAttrValue.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemStockAttrValueResponse>(response);
            }
            else
            {
                var response = await _orderItemStockAttrValueRepository.GetAsync(predicate: x => x.Id == orderItemStockAttrValue.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedOrderItemStockAttrValueResponse>(response);
            }
        }
    }
}
