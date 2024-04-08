using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Rules;

public class StockAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IStockAttributeValueRepository _stockAttributeValueRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IStockAttributeRepository _stockAttributeRepository;
    public StockAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IStockAttributeValueRepository stockAttributeValueRepository, IStockRepository stockRepository, IStockAttributeRepository stockAttributeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _stockAttributeValueRepository = stockAttributeValueRepository;
        _stockRepository = stockRepository;
        _stockAttributeRepository = stockAttributeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public StockAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(StockAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(StockAttributeValueMessages.LocalityIdNotActive);
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
    public StockAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public StockAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public StockAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public StockAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public StockAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public StockAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _stockAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKATTRIBUTEID RULES
    public StockAttributeValueBusinessRules CheckStockAttributeIdExistence(Guid stockAttributeId)
    {
        var isExists = _stockAttributeRepository.Any(predicate: x => x.Id == stockAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.StockAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.StockAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public StockAttributeValueBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockAttributeValueMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

}
