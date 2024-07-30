using MediatR;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants.OrderShipItemStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Commands.Delete;

public class DeleteOrderShipItemStockCommand : IRequest<DeletedOrderShipItemStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderShipItemStockOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderShipItemStocks"];

    public Guid Id { get; set; }


    public class DeleteOrderShipItemStockCommandHandler : IRequestHandler<DeleteOrderShipItemStockCommand, DeletedOrderShipItemStockResponse>
    {
        private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
        private readonly OrderShipItemStockBusinessRules _orderShipItemStockBusinessRules;

        public DeleteOrderShipItemStockCommandHandler(IOrderShipItemStockRepository orderShipItemStockRepository, OrderShipItemStockBusinessRules orderShipItemStockBusinessRules)
        {
            _orderShipItemStockRepository = orderShipItemStockRepository;
            _orderShipItemStockBusinessRules = orderShipItemStockBusinessRules;
        }

        public async Task<DeletedOrderShipItemStockResponse> Handle(DeleteOrderShipItemStockCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemStockBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderShipItemStock orderShipItemStock = await _orderShipItemStockRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderShipItemStockRepository.DeleteAsync(orderShipItemStock);

            return new DeletedOrderShipItemStockResponse
            {
                Id = orderShipItemStock.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderShipItemStockMessages.RequestExecutedSuccessfully
            };
        }
    }
}

