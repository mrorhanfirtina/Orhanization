using MediatR;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants.TaskStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Delete;

public class DeleteTaskStockCommand : IRequest<DeletedTaskStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, TaskStockOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskStocks"];

    public Guid Id { get; set; }


    public class DeleteTaskStockCommandHandler : IRequestHandler<DeleteTaskStockCommand, DeletedTaskStockResponse>
    {
        private readonly ITaskStockRepository _taskStockRepository;
        private readonly TaskStockBusinessRules _taskStockBusinessRules;

        public DeleteTaskStockCommandHandler(ITaskStockRepository taskStockRepository, TaskStockBusinessRules taskStockBusinessRules)
        {
            _taskStockRepository = taskStockRepository;
            _taskStockBusinessRules = taskStockBusinessRules;
        }

        public async Task<DeletedTaskStockResponse> Handle(DeleteTaskStockCommand request, CancellationToken cancellationToken)
        {
            _taskStockBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            TaskStock taskStock = await _taskStockRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _taskStockRepository.DeleteAsync(taskStock);

            return new DeletedTaskStockResponse
            {
                Id = taskStock.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = TaskStockMessages.RequestExecutedSuccessfully
            };
        }
    }
}
