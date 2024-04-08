using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
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
    public string? CacheGroupKey => "GetOrderItemStockAttrValues";

    public UpdateOrderItemStockAttrValueDto OrderItemStockAttrValue { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedOrderItemStockAttrValueResponse>(await _orderItemStockAttrValueRepository.UpdateAsync(orderItemStockAttrValue));
        }
    }
}
