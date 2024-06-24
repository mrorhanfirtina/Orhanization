using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Rules;

public class ItemPackTypeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IItemPackTypeRepository _itemPackTypeRepository;
    private readonly IUnitRepository _unitRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    public ItemPackTypeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IItemPackTypeRepository itemPackTypeRepository, IItemUnitRepository itemUnitRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _itemPackTypeRepository = itemPackTypeRepository;
        _itemUnitRepository = itemUnitRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ItemPackTypeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ItemPackTypeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ItemPackTypeMessages.LocalityIdNotActive);
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
    public ItemPackTypeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ItemPackTypeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ItemPackTypeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ItemPackTypeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ItemPackTypeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ItemPackTypeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _itemPackTypeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ITEMUNITID RULES
    public ItemPackTypeBusinessRules CheckItemUnitIdExistence(Guid itemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == itemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.ItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.ItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region WEIGHTUNITID RULES
    public ItemPackTypeBusinessRules CheckWeightUnitIdExistence(int weightUnitId)
    {
        var isExists = _unitRepository.Any(predicate: x => x.Id == weightUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.LenghtUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.LenghtUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LENGHTUNITID RULES
    public ItemPackTypeBusinessRules CheckLenghtUnitIdExistence(int lenghtUnitId)
    {
        var isExists = _unitRepository.Any(predicate: x => x.Id == lenghtUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.VolumeUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.VolumeUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region VOLUMEUNITID RULES
    public ItemPackTypeBusinessRules CheckVolumeUnitIdExistence(int volumeUnitId)
    {
        var isExists = _unitRepository.Any(predicate: x => x.Id == volumeUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.WeightUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ItemPackTypeMessages.WeightUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

}
