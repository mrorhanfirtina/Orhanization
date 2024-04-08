using Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.TaskStocks.Rules;

public class TaskStockBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ITaskStockRepository _taskStockRepository;
    private readonly IWorkTaskRepository _workTaskRepository;
    private readonly IStockRepository _stockRepository;
    public TaskStockBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ITaskStockRepository taskStockRepository, IWorkTaskRepository workTaskRepository, IStockRepository stockRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _taskStockRepository = taskStockRepository;
        _workTaskRepository = workTaskRepository;
        _stockRepository = stockRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public TaskStockBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(TaskStockMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(TaskStockMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(TaskStockMessages.LocalityIdNotActive);
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
    public TaskStockBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public TaskStockBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public TaskStockBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public TaskStockBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public TaskStockBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public TaskStockBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _taskStockRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(TaskStockMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(TaskStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(TaskStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(TaskStockMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public TaskStockBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(TaskStockMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(TaskStockMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region WORKTASKID RULES
    public TaskStockBusinessRules CheckWorkTaskIdExistence(Guid workTaskId)
    {
        var isExists = _workTaskRepository.Any(predicate: x => x.Id == workTaskId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(TaskStockMessages.WorkTaskIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(TaskStockMessages.WorkTaskIdNotExistsError);
        }

        return this;
    }
    #endregion

}