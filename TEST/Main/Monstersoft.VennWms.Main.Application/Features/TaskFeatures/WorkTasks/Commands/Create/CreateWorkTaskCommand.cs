using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Create;

public class CreateWorkTaskCommand : IRequest<CreatedWorkTaskResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetWorkTasks";

    public CreateWorkTaskDto WorkTask { get; set; }
    public WorkTasksDetailLevel? DetailLevel { get; set; }


    public class CreateWorkTaskCommandHandler : IRequestHandler<CreateWorkTaskCommand, CreatedWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public CreateWorkTaskCommandHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<CreatedWorkTaskResponse> Handle(CreateWorkTaskCommand request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.WorkTask.Code)
            .CheckDepositorIdExistence(request.WorkTask.DepositorId)
            .CheckFromLocationIdExistence(request.WorkTask.FromLocationId)
            .CheckToLocaitonIdExistence(request.WorkTask.ToLocationId)
            .CheckTaskListIdExistence(request.WorkTask.TaskListId)
            .CheckStockIdExistence(request.WorkTask.StockId)
            .CheckTransactionTypeIdExistence(request.WorkTask.TransactionTypeId)
            .CheckStatusIdExistence(request.WorkTask.StatusId);



            WorkTask workTask = _mapper.Map<WorkTask>(request.WorkTask);
            workTask.Id = Guid.NewGuid();
            workTask.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            workTask.CreatedDate = DateTime.Now;

            await _workTaskRepository.AddAsync(workTask);

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

                return _mapper.Map<CreatedWorkTaskResponse>(response);
            }
            else
            {
                var response = await _workTaskRepository.GetAsync(predicate: x => x.Id == workTask.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedWorkTaskResponse>(response);
            }
        }
    }
}

