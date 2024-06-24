using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants.OrderOperationClaims;



namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Delete;

public class DeleteOrderCommand : IRequest<DeletedOrderResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrders";

    public Guid Id { get; set; }


    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, DeletedOrderResponse>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderBusinessRules _orderBusinessRules;

        public DeleteOrderCommandHandler(IOrderRepository orderRepository, OrderBusinessRules orderBusinessRules)
        {
            _orderRepository = orderRepository;
            _orderBusinessRules = orderBusinessRules;
        }

        public async Task<DeletedOrderResponse> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            _orderBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Order order = await _orderRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.OrderShipment)
                           .Include(y => y.OrderMemos)
                           .Include(y => y.OrderAttributeValues)
                           .Include(y => y.OrderItems)
                                .Include(y => y.OrderItems).ThenInclude(z => z.OrderShipItems)
                                .Include(y => y.OrderItems).ThenInclude(z => z.OrderItemStockAttrValues)
                                .Include(y => y.OrderItems).ThenInclude(z => z.OrderItemMemos),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _orderRepository.DeleteAsync(order);

            return new DeletedOrderResponse
            {
                Id = order.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = order.DepositorId,
                IsSuccess = true,
                Message = OrderMessages.RequestExecutedSuccessfully
            };
        }
    }
}
