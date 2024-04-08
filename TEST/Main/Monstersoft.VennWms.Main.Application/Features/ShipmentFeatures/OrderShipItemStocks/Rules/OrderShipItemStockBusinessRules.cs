using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemStocks.Rules;

public class OrderShipItemStockBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IOrderShipItemStockRepository _orderShipItemStockRepository;
    private readonly IStockPackTypeRepository _stockPackTypeRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IOrderShipItemTaskRepository _orderShipItemTaskRepository;
    private readonly IOrderShipItemRepository _orderShipItemRepository;
    public OrderShipItemStockBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IOrderShipItemStockRepository orderShipItemStockRepository, IStockPackTypeRepository stockPackTypeRepository, IStockRepository stockRepository, IOrderShipItemTaskRepository orderShipItemTaskRepository, IOrderShipItemRepository orderShipItemRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _orderShipItemStockRepository = orderShipItemStockRepository;
        _stockPackTypeRepository = stockPackTypeRepository;
        _stockRepository = stockRepository;
        _orderShipItemTaskRepository = orderShipItemTaskRepository;
        _orderShipItemRepository = orderShipItemRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public OrderShipItemStockBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(OrderShipItemStockMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(OrderShipItemStockMessages.LocalityIdNotActive);
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
    public OrderShipItemStockBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public OrderShipItemStockBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public OrderShipItemStockBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public OrderShipItemStockBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public OrderShipItemStockBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public OrderShipItemStockBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _orderShipItemStockRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERSHIPITEMID RULES
    public OrderShipItemStockBusinessRules CheckOrderShipItemIdExistence(Guid orderShipItemId)
    {
        var isExists = _orderShipItemRepository.Any(predicate: x => x.Id == orderShipItemId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.OrderShipItemIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.OrderShipItemIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKPACKTYPEID RULES
    public OrderShipItemStockBusinessRules CheckStockPackTypeIdExistence(Guid stockPackTypeId)
    {
        var isExists = _stockPackTypeRepository.Any(predicate: x => x.Id == stockPackTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.OrderShipItemTaskIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.OrderShipItemTaskIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERSHIPITEMTASKID RULES
    public OrderShipItemStockBusinessRules CheckOrderShipItemTaskIdExistence(Guid orderShipItemTaskId)
    {
        var isExists = _orderShipItemTaskRepository.Any(predicate: x => x.Id == orderShipItemTaskId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public OrderShipItemStockBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.StockPackTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderShipItemStockMessages.StockPackTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
