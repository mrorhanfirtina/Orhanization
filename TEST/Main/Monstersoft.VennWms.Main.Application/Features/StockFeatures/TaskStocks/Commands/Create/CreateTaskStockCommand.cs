using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants.TaskStockOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Create;

public class CreateTaskStockCommand : IRequest<CreatedTaskStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskStocks"];

    public CreateTaskStockDto TaskStock { get; set; }
    public TaskStocksDetailLevel? DetailLevel { get; set; }

    public class CreateTaskStockCommandHandler : IRequestHandler<CreateTaskStockCommand, CreatedTaskStockResponse>
    {
        private readonly ITaskStockRepository _taskStockRepository;
        private readonly TaskStockBusinessRules _taskStockBusinessRules;
        private readonly IMapper _mapper;

        public CreateTaskStockCommandHandler(ITaskStockRepository taskStockRepository, IMapper mapper, TaskStockBusinessRules taskStockBusinessRules)
        {
            _taskStockRepository = taskStockRepository;
            _mapper = mapper;
            _taskStockBusinessRules = taskStockBusinessRules;
        }

        public async Task<CreatedTaskStockResponse> Handle(CreateTaskStockCommand request, CancellationToken cancellationToken)
        {
            _taskStockBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckWorkTaskIdExistence(request.TaskStock.WorkTaskId)
                .CheckStockIdExistence(request.TaskStock.StockId);

            TaskStock taskStock = _mapper.Map<TaskStock>(request.TaskStock);
            taskStock.Id = Guid.NewGuid();
            taskStock.CreatedDate = DateTime.Now;

            await _taskStockRepository.AddAsync(taskStock);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _taskStockRepository.GetAsync(predicate: x => x.Id == taskStock.Id,
                include: x =>
                {
                    IQueryable<TaskStock> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);
                    }

                    if (detailLevel.IncludeWorkTask)
                    {
                        query = query.Include(y => y.WorkTask);
                    }

                    var includableQuery = query as IIncludableQueryable<TaskStock, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTaskStockResponse>(response);
            }
            else
            {
                var response = await _taskStockRepository.GetAsync(predicate: x => x.Id == taskStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedTaskStockResponse>(response);
            }
        }
    }
}
