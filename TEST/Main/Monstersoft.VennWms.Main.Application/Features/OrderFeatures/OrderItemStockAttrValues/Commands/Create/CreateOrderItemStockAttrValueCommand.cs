using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Create;

public class CreateOrderItemStockAttrValueCommand : IRequest<CreatedOrderItemStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderItemStockAttrValues";

    public CreateOrderItemStockAttrValueDto OrderItemStockAttrValue { get; set; }


    public class CreateOrderItemStockAttrValueCommandHandler : IRequestHandler<CreateOrderItemStockAttrValueCommand, CreatedOrderItemStockAttrValueResponse>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;
        private readonly IMapper _mapper;

        public CreateOrderItemStockAttrValueCommandHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, IMapper mapper, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _mapper = mapper;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
        }

        public async Task<CreatedOrderItemStockAttrValueResponse> Handle(CreateOrderItemStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckOrderItemIdExistence(request.OrderItemStockAttrValue.OrderItemId);

            OrderItemStockAttrValue orderItemStockAttrValue = _mapper.Map<OrderItemStockAttrValue>(request.OrderItemStockAttrValue);
            orderItemStockAttrValue.Id = Guid.NewGuid();
            orderItemStockAttrValue.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedOrderItemStockAttrValueResponse>(await _orderItemStockAttrValueRepository.AddAsync(orderItemStockAttrValue));
        }
    }

}
