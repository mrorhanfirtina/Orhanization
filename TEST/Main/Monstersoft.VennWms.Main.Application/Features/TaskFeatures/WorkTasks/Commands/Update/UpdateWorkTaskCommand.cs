using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
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
    public string? CacheGroupKey => "GetWorkTasks";

    public UpdateWorkTaskDto WorkTask { get; set; }


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

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedWorkTaskResponse>(await _workTaskRepository.UpdateAsync(workTask));
        }
    }
}

