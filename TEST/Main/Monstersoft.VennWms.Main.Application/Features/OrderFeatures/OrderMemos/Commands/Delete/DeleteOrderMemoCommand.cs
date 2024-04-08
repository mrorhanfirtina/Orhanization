using MediatR;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants.OrderMemoOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Delete;

public class DeleteOrderMemoCommand : IRequest<DeletedOrderMemoResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, OrderMemoOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetOrderMemos";

    public Guid Id { get; set; }


    public class DeleteOrderMemoCommandHandler : IRequestHandler<DeleteOrderMemoCommand, DeletedOrderMemoResponse>
    {
        private readonly IOrderMemoRepository _orderMemoRepository;
        private readonly OrderMemoBusinessRules _orderMemoBusinessRules;

        public DeleteOrderMemoCommandHandler(IOrderMemoRepository orderMemoRepository, OrderMemoBusinessRules orderMemoBusinessRules)
        {
            _orderMemoRepository = orderMemoRepository;
            _orderMemoBusinessRules = orderMemoBusinessRules;
        }

        public async Task<DeletedOrderMemoResponse> Handle(DeleteOrderMemoCommand request, CancellationToken cancellationToken)
        {
            _orderMemoBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            OrderMemo orderMemo = await _orderMemoRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _orderMemoRepository.DeleteAsync(orderMemo);

            return new DeletedOrderMemoResponse
            {
                Id = orderMemo.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = OrderMemoMessages.RequestExecutedSuccessfully
            };
        }
    }
}

