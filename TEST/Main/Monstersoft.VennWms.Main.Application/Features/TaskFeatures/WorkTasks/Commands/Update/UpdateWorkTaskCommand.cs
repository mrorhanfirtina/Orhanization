using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Update;

public class UpdateWorkTaskCommand : IRequest<UpdatedWorkTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, WorkTaskOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetWorkTasks"];

    public UpdateWorkTaskDto WorkTask { get; set; }
    public WorkTasksDetailLevel? DetailLevel { get; set; }


    public class UpdateWorkTaskCommandHandler : IRequestHandler<UpdateWorkTaskCommand, UpdatedWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public UpdateWorkTaskCommandHandler(IWorkTaskRepository workTaskRepository, WorkTaskBusinessRules workTaskBusinessRules, IMapper mapper)
        {
            _workTaskRepository = workTaskRepository;
            _workTaskBusinessRules = workTaskBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedWorkTaskResponse> Handle(UpdateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.WorkTask.Id)
            .CheckDepositorIdExistence(request.WorkTask.DepositorId)
            .CheckCodeExistenceWhenUpdate(request.WorkTask.Code, request.WorkTask.Id)
            .CheckFromLocationIdExistence(request.WorkTask.FromLocationId)
            .CheckToLocaitonIdExistence(request.WorkTask.ToLocationId)
            .CheckTaskListIdExistence(request.WorkTask.TaskListId)
            .CheckStockIdExistence(request.WorkTask.StockId)
            .CheckTransactionTypeIdExistence(request.WorkTask.TransactionTypeId)
            .CheckStatusIdExistence(request.WorkTask.StatusId);

            WorkTask? currentWorkTask = await _workTaskRepository.GetAsync(predicate: x => x.Id == request.WorkTask.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            WorkTask? workTask = _mapper.Map(request.WorkTask, currentWorkTask);
            workTask.UpdatedDate = DateTime.Now;

            await _workTaskRepository.UpdateAsync(workTask);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _workTaskRepository.GetAsync(predicate: x => x.Id == workTask.Id,
                include: x =>
                {
                    IQueryable<WorkTask> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeFromLocation)
                    {
                        query = query.Include(y => y.FromLocation);
                    }

                    if (detailLevel.IncludeToLocation)
                    {
                        query = query.Include(y => y.ToLocation);
                    }

                    if (detailLevel.IncludeStatus)
                    {
                        query = query.Include(y => y.Status);
                    }

                    if (detailLevel.IncludeTransactionType)
                    {
                        query = query.Include(y => y.TransactionType);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        var depositorDetailLevel = detailLevel.DepositorDetailLevel;

                        if (depositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(y => y.Company);
                        }
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeOrderShipItemTask)
                    {
                        query = query.Include(y => y.OrderShipItemTasks);
                    }

                    if (detailLevel.IncludeStock)
                    {
                        query = query.Include(y => y.Stock);

                        var stockDetailLevel = detailLevel.StockDetailLevel;

                        if (stockDetailLevel.IncludeProduct)
                        {
                            query = query.Include(y => y.Stock).ThenInclude(y => y.Product);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<WorkTask, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedWorkTaskResponse>(response);
            }
            else
            {
                var response = await _workTaskRepository.GetAsync(predicate: x => x.Id == workTask.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedWorkTaskResponse>(response);
            }
        }
    }
}

