using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Rules;

public class StockBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IUnitRepository _unitRepository;
    private readonly IStockContainerRepository _stockContainerRepository;
    private readonly IProductRepository _productRepository;
    private readonly ILocationRepository _locationRepository;
    private readonly IDepositorRepository _depositorRepository;
    public StockBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IStockRepository stockRepository, IUnitRepository unitRepository, IStockContainerRepository stockContainerRepository, IProductRepository productRepository, ILocationRepository locationRepository, IDepositorRepository depositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _stockRepository = stockRepository;
        _unitRepository = unitRepository;
        _stockContainerRepository = stockContainerRepository;
        _productRepository = productRepository;
        _locationRepository = locationRepository;
        _depositorRepository = depositorRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public StockBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(StockMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(StockMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(StockMessages.LocalityIdNotActive);
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
    public StockBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public StockBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public StockBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public StockBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public StockBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public StockBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(StockMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(StockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(StockMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public StockBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOCATIONID RULES
    public StockBusinessRules CheckLocationIdExistence(Guid locationId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == locationId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockMessages.LocationIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.LocationIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTID RULES
    public StockBusinessRules CheckProductIdExistence(Guid productId)
    {
        var isExists = _productRepository.Any(predicate: x => x.Id == productId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockMessages.ProductIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.ProductIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKCONTAINERID RULES
    public StockBusinessRules CheckStockContainerIdExistence(Guid stockContainerId)
    {
        var isExists = _stockContainerRepository.Any(predicate: x => x.Id == stockContainerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockMessages.StockContainerIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.StockContainerIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region UNITID RULES
    public StockBusinessRules CheckUnitIdExistence(int unitId)
    {
        var isExists = _unitRepository.Any(predicate: x => x.Id == unitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockMessages.UnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockMessages.UnitIdNotExistsError);
        }

        return this;
    }
    #endregion

}
