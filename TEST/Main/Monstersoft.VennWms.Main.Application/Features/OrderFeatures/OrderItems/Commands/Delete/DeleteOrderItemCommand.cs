using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Constants.OrderItemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Commands.Delete;

public class DeleteOrderItemCommand : IRequest<DeletedOrderItemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderItemOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderItems";

    public Guid Id { get; set; }


    public class DeleteOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, DeletedOrderItemResponse>
    {
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly OrderItemBusinessRules _orderItemBusinessRules;

        public DeleteOrderItemCommandHandler(IOrderItemRepository orderItemRepository, OrderItemBusinessRules orderItemBusinessRules)
        {
            _orderItemRepository = orderItemRepository;
            _orderItemBusinessRules = orderItemBusinessRules;
        }

        public async Task<DeletedOrderItemResponse> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
        {
            _orderItemBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderItem orderItem = await _orderItemRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderItemRepository.DeleteAsync(orderItem);

            return new DeletedOrderItemResponse
            {
                Id = orderItem.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderItemMessages.RequestExecutedSuccessfully
            };
        }
    }
}
