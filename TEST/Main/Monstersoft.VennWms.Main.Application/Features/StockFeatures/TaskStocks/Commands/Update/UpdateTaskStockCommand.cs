using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Dtos.UpdateDtos;
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


namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Commands.Update;

public class UpdateTaskStockCommand : IRequest<UpdatedTaskStockResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, TaskStockOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetTaskStocks"];

    public UpdateTaskStockDto TaskStock { get; set; }
    public TaskStocksDetailLevel? DetailLevel { get; set; }


    public class UpdateTaskStockCommandHandler : IRequestHandler<UpdateTaskStockCommand, UpdatedTaskStockResponse>
    {
        private readonly ITaskStockRepository _taskStockRepository;
        private readonly TaskStockBusinessRules _taskStockBusinessRules;
        private readonly IMapper _mapper;

        public UpdateTaskStockCommandHandler(ITaskStockRepository taskStockRepository, TaskStockBusinessRules taskStockBusinessRules, IMapper mapper)
        {
            _taskStockRepository = taskStockRepository;
            _taskStockBusinessRules = taskStockBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedTaskStockResponse> Handle(UpdateTaskStockCommand request, CancellationToken cancellationToken)
        {
            _taskStockBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.TaskStock.Id)
            .CheckWorkTaskIdExistence(request.TaskStock.WorkTaskId)
            .CheckStockIdExistence(request.TaskStock.StockId);

            TaskStock? currentTaskStock = await _taskStockRepository.GetAsync(predicate: x => x.Id == request.TaskStock.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            TaskStock? taskStock = _mapper.Map(request.TaskStock, currentTaskStock);
            taskStock.UpdatedDate = DateTime.Now;

            await _taskStockRepository.UpdateAsync(taskStock);

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

                return _mapper.Map<UpdatedTaskStockResponse>(response);
            }
            else
            {
                var response = await _taskStockRepository.GetAsync(predicate: x => x.Id == taskStock.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedTaskStockResponse>(response);
            }
        }
    }
}
