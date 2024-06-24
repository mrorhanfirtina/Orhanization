using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;

public class WorkTaskBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IWorkTaskRepository _workTaskRepository;
    private readonly ITransactionTypeRepository _transactionTypeRepository;
    private readonly ILocationRepository _locationRepository;
    private readonly ITaskListRepository _taskListRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly IDepositorRepository _depositorRepository;
    public WorkTaskBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, 
        IWorkTaskRepository workTaskRepository, 
        ITransactionTypeRepository transactionTypeRepository, 
        ILocationRepository locationRepository, 
        ITaskListRepository taskListRepository, 
        IStockRepository stockRepository, 
        IStatusRepository statusRepository, 
        IDepositorRepository depositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _workTaskRepository = workTaskRepository;
        _transactionTypeRepository = transactionTypeRepository;
        _taskListRepository = taskListRepository;
        _stockRepository = stockRepository;
        _statusRepository = statusRepository;
        _locationRepository = locationRepository;
        _depositorRepository = depositorRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public WorkTaskBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(WorkTaskMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(WorkTaskMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(WorkTaskMessages.LocalityIdNotActive);
        }

        DepositorCompanyId = depositorCompanyId;

        return this;
    }

    // Istek tipini sakliyoruz.
    private void SetRequestType(RequestType requestType)
    {
        CurrentRequest = requestType;
    }

    // Istek tipini Get olarak ayarliyoruz.
    public WorkTaskBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public WorkTaskBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public WorkTaskBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public WorkTaskBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public WorkTaskBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public WorkTaskBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _workTaskRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(WorkTaskMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public WorkTaskBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region FROMLOCATIONID RULES
    public WorkTaskBusinessRules CheckFromLocationIdExistence(Guid fromLocationId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == fromLocationId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.FromLocationIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.FromLocationIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STATUSID RULES
    public WorkTaskBusinessRules CheckStatusIdExistence(int statusId)
    {
        var isExists = _statusRepository.Any(predicate: x => x.Id == statusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.StatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.StatusIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public WorkTaskBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TASKLISTID RULES
    public WorkTaskBusinessRules CheckTaskListIdExistence(Guid taskListId)
    {
        var isExists = _taskListRepository.Any(predicate: x => x.Id == taskListId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.TaskListIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.TaskListIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TOLOCAITONID RULES
    public WorkTaskBusinessRules CheckToLocaitonIdExistence(Guid toLocaitonId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == toLocaitonId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.ToLocaitonIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.ToLocaitonIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TRANSACTIONTYPEID RULES
    public WorkTaskBusinessRules CheckTransactionTypeIdExistence(int transactionTypeId)
    {
        var isExists = _transactionTypeRepository.Any(predicate: x => x.Id == transactionTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.TransactionTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(WorkTaskMessages.TransactionTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public WorkTaskBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _workTaskRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(WorkTaskMessages.CodeExistsError);
            }
        }

        return this;
    }

    public WorkTaskBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _workTaskRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(WorkTaskMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}