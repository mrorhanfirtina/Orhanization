using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Rules;

public class OrderShipItemTaskBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
    private readonly IWorkTaskRepository _workTaskRepository;
    private readonly IOrderShipItemRepository _orderShipItemRepository;
    public OrderShipItemTaskBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IOrderShipItemTaskRepository orderShipItemTaskRepository, IWorkTaskRepository workTaskRepository, IOrderShipItemRepository orderShipItemRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _orderShipItemTaskRepository = orderShipItemTaskRepository;
        _workTaskRepository = workTaskRepository;
        _orderShipItemRepository = orderShipItemRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public OrderShipItemTaskBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(OrderShipItemTaskMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(OrderShipItemTaskMessages.LocalityIdNotActive);
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
    public OrderShipItemTaskBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public OrderShipItemTaskBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public OrderShipItemTaskBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public OrderShipItemTaskBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public OrderShipItemTaskBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public OrderShipItemTaskBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _orderShipItemTaskRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERSHIPITEMID RULES
    public OrderShipItemTaskBusinessRules CheckOrderShipItemIdExistence(Guid orderShipItemId)
    {
        var isExists = _orderShipItemRepository.Any(predicate: x => x.Id == orderShipItemId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.OrderShipItemIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.OrderShipItemIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region WORKTASKID RULES
    public OrderShipItemTaskBusinessRules CheckWorkTaskIdExistence(Guid workTaskId)
    {
        var isExists = _workTaskRepository.Any(predicate: x => x.Id == workTaskId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.WorkTaskIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemTaskMessages.WorkTaskIdNotExistsError);
        }

        return this;
    }
    #endregion

}
