using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Commands.Delete;

public class DeleteOrderShipItemCommand : IRequest<DeletedOrderShipItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderShipItemOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderShipItems";

    public Guid Id { get; set; }


    public class DeleteOrderShipItemCommandHandler : IRequestHandler<DeleteOrderShipItemCommand, DeletedOrderShipItemResponse>
    {
        private readonly IOrderShipItemRepository _orderShipItemRepository;
        private readonly OrderShipItemBusinessRules _orderShipItemBusinessRules;

        public DeleteOrderShipItemCommandHandler(IOrderShipItemRepository orderShipItemRepository, OrderShipItemBusinessRules orderShipItemBusinessRules)
        {
            _orderShipItemRepository = orderShipItemRepository;
            _orderShipItemBusinessRules = orderShipItemBusinessRules;
        }

        public async Task<DeletedOrderShipItemResponse> Handle(DeleteOrderShipItemCommand request, CancellationToken cancellationToken)
        {
            _orderShipItemBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderShipItem orderShipItem = await _orderShipItemRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.OrderShipItemTasks)
                           .Include(y => y.OrderShipItemTasks).ThenInclude(m => m.OrderShipItemStocks),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _orderShipItemRepository.DeleteAsync(orderShipItem);

            return new DeletedOrderShipItemResponse
            {
                Id = orderShipItem.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderShipItemMessages.RequestExecutedSuccessfully
            };
        }
    }
}
