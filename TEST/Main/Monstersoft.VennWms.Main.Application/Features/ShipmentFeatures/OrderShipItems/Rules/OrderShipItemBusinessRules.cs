using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Rules;

public class OrderShipItemBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IOrderShipItemRepository _orderShipItemRepository;
    private readonly IProgressStatusRepository _progressStatusRepository;
    private readonly IOrderShipmentRepository _orderShipmentRepository;
    private readonly IOrderItemRepository _orderItemRepository;
    public OrderShipItemBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IOrderShipItemRepository orderShipItemRepository, IProgressStatusRepository progressStatusRepository, IOrderShipmentRepository orderShipmentRepository, IOrderItemRepository orderItemRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _orderShipItemRepository = orderShipItemRepository;
        _progressStatusRepository = progressStatusRepository;
        _orderShipmentRepository = orderShipmentRepository;
        _orderItemRepository = orderItemRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public OrderShipItemBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(OrderShipItemMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(OrderShipItemMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(OrderShipItemMessages.LocalityIdNotActive);
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
    public OrderShipItemBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public OrderShipItemBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public OrderShipItemBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public OrderShipItemBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public OrderShipItemBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public OrderShipItemBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _orderShipItemRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(OrderShipItemMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERITEMID RULES
    public OrderShipItemBusinessRules CheckOrderItemIdExistence(Guid orderItemId)
    {
        var isExists = _orderItemRepository.Any(predicate: x => x.Id == orderItemId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.OrderItemIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.OrderItemIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERSHIPMENTID RULES
    public OrderShipItemBusinessRules CheckOrderShipmentIdExistence(Guid orderShipmentId)
    {
        var isExists = _orderShipmentRepository.Any(predicate: x => x.Id == orderShipmentId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.OrderShipmentIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.OrderShipmentIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PROGRESSSTATUSID RULES
    public OrderShipItemBusinessRules CheckProgressStatusIdExistence(int progressStatusId)
    {
        var isExists = _progressStatusRepository.Any(predicate: x => x.Id == progressStatusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.ProgressStatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemMessages.ProgressStatusIdNotExistsError);
        }

        return this;
    }
    #endregion

}
