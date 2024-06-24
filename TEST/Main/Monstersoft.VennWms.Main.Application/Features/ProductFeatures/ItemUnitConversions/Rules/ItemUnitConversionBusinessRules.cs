using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Rules;

public class ItemUnitConversionBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IItemUnitConversionRepository _itemUnitConversionRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    public ItemUnitConversionBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IItemUnitConversionRepository itemUnitConversionRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _itemUnitConversionRepository = itemUnitConversionRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ItemUnitConversionBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ItemUnitConversionMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ItemUnitConversionMessages.LocalityIdNotActive);
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
    public ItemUnitConversionBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ItemUnitConversionBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ItemUnitConversionBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ItemUnitConversionBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ItemUnitConversionBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ItemUnitConversionBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _itemUnitConversionRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CONVERTEDITEMUNITID RULES
    public ItemUnitConversionBusinessRules CheckConvertedItemUnitIdExistence(Guid convertedItemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == convertedItemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.ConvertedItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.ConvertedItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region REFERENCEITEMUNITID RULES
    public ItemUnitConversionBusinessRules CheckReferenceItemUnitIdExistence(Guid referenceItemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == referenceItemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.ReferenceItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemUnitConversionMessages.ReferenceItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

}
