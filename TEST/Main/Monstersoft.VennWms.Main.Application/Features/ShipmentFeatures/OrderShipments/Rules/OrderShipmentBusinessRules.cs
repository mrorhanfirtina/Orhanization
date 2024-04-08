using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Rules;

public class OrderShipmentBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IOrderShipmentRepository _orderShipmentRepository;
    private readonly IShipmentRepository _shipmentRepository;
    private readonly IProgressStatusRepository _progressStatusRepository;
    private readonly IOrderRepository _orderRepository;
    public OrderShipmentBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IOrderShipmentRepository orderShipmentRepository, IShipmentRepository shipmentRepository, IProgressStatusRepository progressStatusRepository, IOrderRepository orderRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _orderShipmentRepository = orderShipmentRepository;
        _shipmentRepository = shipmentRepository;
        _progressStatusRepository = progressStatusRepository;
        _orderRepository = orderRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public OrderShipmentBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(OrderShipmentMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(OrderShipmentMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(OrderShipmentMessages.LocalityIdNotActive);
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
    public OrderShipmentBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public OrderShipmentBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public OrderShipmentBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public OrderShipmentBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public OrderShipmentBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public OrderShipmentBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _orderShipmentRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(OrderShipmentMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERID RULES
    public OrderShipmentBusinessRules CheckOrderIdExistence(Guid orderId)
    {
        var isExists = _orderRepository.Any(predicate: x => x.Id == orderId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.OrderIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.OrderIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PROGRESSSTATUSID RULES
    public OrderShipmentBusinessRules CheckProgressStatusIdExistence(int progressStatusId)
    {
        var isExists = _progressStatusRepository.Any(predicate: x => x.Id == progressStatusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.ProgressStatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.ProgressStatusIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region SHIPMENTID RULES
    public OrderShipmentBusinessRules CheckShipmentIdExistence(Guid shipmentId)
    {
        var isExists = _shipmentRepository.Any(predicate: x => x.Id == shipmentId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.ShipmentIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipmentMessages.ShipmentIdNotExistsError);
        }

        return this;
    }
    #endregion

}
