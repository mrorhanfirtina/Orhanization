using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Constants.OrderPriorityOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderPriorities.Commands.Delete;

public class DeleteOrderPriorityCommand : IRequest<DeletedOrderPriorityResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, OrderPriorityOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetOrderPriorities"];

    public Guid Id { get; set; }

    public class DeleteOrderPriorityCommandHandler : IRequestHandler<DeleteOrderPriorityCommand, DeletedOrderPriorityResponse>
    {
        private readonly IOrderPriorityRepository _orderPriorityRepository;
        private readonly OrderPriorityBusinessRules _orderPriorityBusinessRules;

        public DeleteOrderPriorityCommandHandler(IOrderPriorityRepository orderPriorityRepository, OrderPriorityBusinessRules orderPriorityBusinessRules)
        {
            _orderPriorityRepository = orderPriorityRepository;
            _orderPriorityBusinessRules = orderPriorityBusinessRules;
        }

        public async Task<DeletedOrderPriorityResponse> Handle(DeleteOrderPriorityCommand request, CancellationToken cancellationToken)
        {
            _orderPriorityBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderPriority orderPriority = await _orderPriorityRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderPriorityRepository.DeleteAsync(orderPriority);

            return new DeletedOrderPriorityResponse
            {
                Id = orderPriority.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderPriorityMessages.RequestExecutedSuccessfully
            };
        }
    }
}


