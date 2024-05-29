using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants.OrderShipItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Update;

public class UpdateOrderShipItemCommand : IRequest<UpdatedOrderShipItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, OrderShipItemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItems";

    public UpdateOrderShipItemDto OrderShipItem { get; set; }


    public class UpdateOrderShipItemCommandHandler : IRequestHandler<UpdateOrderShipItemCommand, UpdatedOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly IMapper _mapper;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;

        public UpdateOrderShipItemCommandHandler(IOrderShipItemRepository orderShipItemRepository, IMapper mapper, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _mapper = mapper;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<UpdatedOrderShipItemResponse> Handle(UpdateOrderShipItemCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.OrderShipItem.Id);

            OrderShipItem? currentOrderShipItem = await _orderShipItemRepository.GetAsync(predicate: x => x.Id == request.OrderShipItem.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            OrderShipItem? orderShipItem = _mapper.Map(request.OrderShipItem, currentOrderShipItem);

            orderShipItem.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedOrderShipItemResponse>(await _orderShipItemRepository.UpdateAsync(orderShipItem));
        }
    }
}
