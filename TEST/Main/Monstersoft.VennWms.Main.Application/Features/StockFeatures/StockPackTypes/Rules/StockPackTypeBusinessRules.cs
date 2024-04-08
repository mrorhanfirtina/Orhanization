using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Rules;

public class StockPackTypeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IStockPackTypeRepository _stockPackTypeRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    public StockPackTypeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IStockPackTypeRepository stockPackTypeRepository, IStockRepository stockRepository, IItemUnitRepository itemUnitRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _stockPackTypeRepository = stockPackTypeRepository;
        _stockRepository = stockRepository;
        _itemUnitRepository = itemUnitRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public StockPackTypeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(StockPackTypeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(StockPackTypeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(StockPackTypeMessages.LocalityIdNotActive);
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
    public StockPackTypeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public StockPackTypeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public StockPackTypeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public StockPackTypeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public StockPackTypeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public StockPackTypeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _stockPackTypeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(StockPackTypeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ITEMUNITID RULES
    public StockPackTypeBusinessRules CheckItemUnitIdExistence(Guid itemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == itemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.ItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.ItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public StockPackTypeBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockPackTypeMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

}
