using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Constants.OrderItemMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Delete;

public class DeleteOrderItemMemoCommand : IRequest<DeletedOrderItemMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderItemMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItemMemos"];

    public Guid Id { get; set; }


    public class DeleteOrderItemMemoCommandHandler : IRequestHandler<DeleteOrderItemMemoCommand, DeletedOrderItemMemoResponse>
    {
        private readonly IOrderItemMemoRepository _orderItemMemoRepository;
        private readonly OrderItemMemoBusinessRules _orderItemMemoBusinessRules;

        public DeleteOrderItemMemoCommandHandler(IOrderItemMemoRepository orderItemMemoRepository, OrderItemMemoBusinessRules orderItemMemoBusinessRules)
        {
            _orderItemMemoRepository = orderItemMemoRepository;
            _orderItemMemoBusinessRules = orderItemMemoBusinessRules;
        }

        public async Task<DeletedOrderItemMemoResponse> Handle(DeleteOrderItemMemoCommand request, CancellationToken cancellationToken)
        {
            _orderItemMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderItemMemo orderItemMemo = await _orderItemMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderItemMemoRepository.DeleteAsync(orderItemMemo);

            return new DeletedOrderItemMemoResponse
            {
                Id = orderItemMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderItemMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}

