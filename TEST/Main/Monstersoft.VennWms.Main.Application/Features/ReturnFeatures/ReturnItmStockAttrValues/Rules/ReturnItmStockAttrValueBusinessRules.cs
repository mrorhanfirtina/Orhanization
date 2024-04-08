using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Rules;

public class ReturnItmStockAttrValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReturnItmStockAttrValueRepository _returnItmStockAttrValueRepository;
    private readonly IStockAttributeRepository _stockAttributeRepository;
    private readonly IReturnItemRepository _returnItemRepository;
    public ReturnItmStockAttrValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReturnItmStockAttrValueRepository returnItmStockAttrValueRepository, IStockAttributeRepository stockAttributeRepository, IReturnItemRepository returnItemRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _returnItmStockAttrValueRepository = returnItmStockAttrValueRepository;
        _stockAttributeRepository = stockAttributeRepository;
        _returnItemRepository = returnItemRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReturnItmStockAttrValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.LocalityIdNotActive);
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
    public ReturnItmStockAttrValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReturnItmStockAttrValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReturnItmStockAttrValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReturnItmStockAttrValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReturnItmStockAttrValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReturnItmStockAttrValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _returnItmStockAttrValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RETURNITEMID RULES
    public ReturnItmStockAttrValueBusinessRules CheckReturnItemIdExistence(Guid returnItemId)
    {
        var isExists = _returnItemRepository.Any(predicate: x => x.Id == returnItemId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.ReturnItemIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.ReturnItemIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKATTRIBUTEID RULES
    public ReturnItmStockAttrValueBusinessRules CheckStockAttributeIdExistence(Guid stockAttributeId)
    {
        var isExists = _stockAttributeRepository.Any(predicate: x => x.Id == stockAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.StockAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItmStockAttrValueMessages.StockAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
