using MediatR;
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


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Delete;

public class DeleteOrderItemStockAttrValueCommand : IRequest<DeletedOrderItemStockAttrValueResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderItemStockAttrValueOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderItemStockAttrValues"];

    public Guid Id { get; set; }


    public class DeleteOrderItemStockAttrValueCommandHandler : IRequestHandler<DeleteOrderItemStockAttrValueCommand, DeletedOrderItemStockAttrValueResponse>
    {
        private readonly IOrderItemStockAttrValueRepository _orderItemStockAttrValueRepository;
        private readonly OrderItemStockAttrValueBusinessRules _orderItemStockAttrValueBusinessRules;

        public DeleteOrderItemStockAttrValueCommandHandler(IOrderItemStockAttrValueRepository orderItemStockAttrValueRepository, OrderItemStockAttrValueBusinessRules orderItemStockAttrValueBusinessRules)
        {
            _orderItemStockAttrValueRepository = orderItemStockAttrValueRepository;
            _orderItemStockAttrValueBusinessRules = orderItemStockAttrValueBusinessRules;
        }

        public async Task<DeletedOrderItemStockAttrValueResponse> Handle(DeleteOrderItemStockAttrValueCommand request, CancellationToken cancellationToken)
        {
            _orderItemStockAttrValueBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderItemStockAttrValue orderItemStockAttrValue = await _orderItemStockAttrValueRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderItemStockAttrValueRepository.DeleteAsync(orderItemStockAttrValue);

            return new DeletedOrderItemStockAttrValueResponse
            {
                Id = orderItemStockAttrValue.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderItemStockAttrValueMessages.RequestExecutedSuccessfully
            };
        }
    }
}
