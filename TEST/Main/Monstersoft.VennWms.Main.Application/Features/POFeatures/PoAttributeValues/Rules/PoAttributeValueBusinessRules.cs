using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributeValues.Rules;

public class PoAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IPoAttributeValueRepository _poAttributeValueRepository;
    private readonly IPurchaseOrderRepository _purchaseOrderRepository;
    private readonly IPoAttributeRepository _poAttributeRepository;
    public PoAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IPoAttributeValueRepository poAttributeValueRepository, IPurchaseOrderRepository purchaseOrderRepository, IPoAttributeRepository poAttributeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _poAttributeValueRepository = poAttributeValueRepository;
        _purchaseOrderRepository = purchaseOrderRepository;
        _poAttributeRepository = poAttributeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public PoAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(PoAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(PoAttributeValueMessages.LocalityIdNotActive);
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
    public PoAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public PoAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public PoAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public PoAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public PoAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public PoAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _poAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region POATTRIBUTEID RULES
    public PoAttributeValueBusinessRules CheckPoAttributeIdExistence(Guid poAttributeId)
    {
        var isExists = _poAttributeRepository.Any(predicate: x => x.Id == poAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.PoAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.PoAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PURCHASEORDERID RULES
    public PoAttributeValueBusinessRules CheckPurchaseOrderIdExistence(Guid purchaseOrderId)
    {
        var isExists = _purchaseOrderRepository.Any(predicate: x => x.Id == purchaseOrderId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.PurchaseOrderIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeValueMessages.PurchaseOrderIdNotExistsError);
        }

        return this;
    }
    #endregion

}
