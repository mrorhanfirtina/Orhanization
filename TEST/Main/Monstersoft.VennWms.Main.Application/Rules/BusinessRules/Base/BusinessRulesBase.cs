using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Rules.BusinessRules.Constants;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Rules.BusinessRules.Base;

public abstract class BusinessRulesBase
{
    private readonly IDepositorRepository _depositorRepository;

    protected BusinessRulesBase(IDepositorRepository depositorRepository)
    {
        _depositorRepository = depositorRepository;
    }

    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid LocalityId { get; set; } = Guid.Empty;

    // İstek tipini saklıyoruz.
    public void SetRequestType(RequestType requestType)
    {
        CurrentRequest = requestType;
    }

    // Burada depositorId'yi miras alan sınıflarda kullanmak için Guid'e çevirip saklıyoruz.
    public void CheckDepositor(string localityId)
    {
        Guid depositorId = Guid.Parse(localityId);

        if (depositorId == Guid.Empty)
        {
            throw new BusinessException(BaseBusinessRulesMessages.EmptyLocalityId);
        }

        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId, withDeleted: false);

        if (!isExists)
        {
            throw new BusinessException(BaseBusinessRulesMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorRepository.Any(predicate: x => x.Id == depositorId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(BaseBusinessRulesMessages.LocalityIdNotActive);
        }

        LocalityId = depositorId;
    }

    // İstek tipini Get olarak ayarlıyoruz.
    public BusinessRulesBase GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // İstek tipini Create olarak ayarlıyoruz.
    public BusinessRulesBase CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // İstek tipini Update olarak ayarlıyoruz.
    public BusinessRulesBase UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // İstek tipini Delete olarak ayarlıyoruz.
    public BusinessRulesBase DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // İstek tipini Null olarak ayarlıyoruz.
    public BusinessRulesBase NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }


    // Istek ile gelen id mevcut db de var mı?
    public virtual BusinessRulesBase IsIdExists(Guid Id)
    {
        return this;
    }

    // Istek ile gelen id mevcut db de var mı?
    public virtual BusinessRulesBase IsIdExists(int Id)
    {
        return this;
    }

    // Istek ile gelen kod depositore ait kodlar arasında var mı?
    public virtual BusinessRulesBase IsCodeExists(string code)
    {
        return this;
    }

    // Istekte kod için mükerrer kayıt gönderilmiş mi?
    public virtual BusinessRulesBase IsCodeDuplicateInRequest(string[] codes)
    {
        return this;
    }

    // Istek ile gelen barcode id mevcut db de var mı?
    public virtual BusinessRulesBase IsBarcodeIdExists(Guid barcodeId)
    {
        return this;
    }

    // Istek ile gelen printer id mevcut db de var mı?
    public virtual BusinessRulesBase IsPrinterIdExists(Guid printerId)
    {
        return this;
    }

}