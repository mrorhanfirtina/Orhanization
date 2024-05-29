using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Create;

public class CreateOrderShipItemCommand : IRequest<CreatedOrderShipItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItems";

    public CreateOrderShipItemDto OrderShipItem { get; set; }


    public class CreateOrderShipItemCommandHandler : IRequestHandler<CreateOrderShipItemCommand, CreatedOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;

        public CreateOrderShipItemCommandHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _mapper = mapper;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<CreatedOrderShipItemResponse> Handle(CreateOrderShipItemCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId);

            OrderShipItem? orderShipItem = _mapper.Map<OrderShipItem>(request.OrderShipItem);

            orderShipItem.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedOrderShipItemResponse>(await _orderShipItemRepository.AddAsync(orderShipItem));
        }
    }
}
