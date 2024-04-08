using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Rules;

public class ReturnItemBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReturnItemRepository _returnItemRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly IReturnRepository _returnRepository;
    private readonly IProductRepository _productRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    public ReturnItemBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReturnItemRepository returnItemRepository, IStatusRepository statusRepository, IReturnRepository returnRepository, IProductRepository productRepository, IItemUnitRepository itemUnitRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _returnItemRepository = returnItemRepository;
        _statusRepository = statusRepository;
        _returnRepository = returnRepository;
        _productRepository = productRepository;
        _itemUnitRepository = itemUnitRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReturnItemBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReturnItemMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReturnItemMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReturnItemMessages.LocalityIdNotActive);
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
    public ReturnItemBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReturnItemBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReturnItemBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReturnItemBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReturnItemBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReturnItemBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _returnItemRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReturnItemMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ITEMUNITID RULES
    public ReturnItemBusinessRules CheckItemUnitIdExistence(Guid itemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == itemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STATUSID RULES
    public ReturnItemBusinessRules CheckStatusIdExistence(int statusId)
    {
        var isExists = _statusRepository.Any(predicate: x => x.Id == statusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ProductIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ProductIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTID RULES
    public ReturnItemBusinessRules CheckProductIdExistence(Guid productId)
    {
        var isExists = _productRepository.Any(predicate: x => x.Id == productId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ReturnIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.ReturnIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RETURNID RULES
    public ReturnItemBusinessRules CheckReturnIdExistence(Guid returnId)
    {
        var isExists = _returnRepository.Any(predicate: x => x.Id == returnId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.StatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnItemMessages.StatusIdNotExistsError);
        }

        return this;
    }
    #endregion

}
