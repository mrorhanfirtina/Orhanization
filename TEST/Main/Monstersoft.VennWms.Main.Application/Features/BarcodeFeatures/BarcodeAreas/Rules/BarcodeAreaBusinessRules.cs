using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Rules;

public class BarcodeAreaBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IBarcodeAreaRepository _barcodeAreaRepository;
    private readonly IBarcodeRepository _barcodeRepository;
    public BarcodeAreaBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IBarcodeAreaRepository barcodeAreaRepository, IBarcodeRepository barcodeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _barcodeAreaRepository = barcodeAreaRepository;
        _barcodeRepository = barcodeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public BarcodeAreaBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(BarcodeAreaMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null && !x.DeletedDate.HasValue);

        if (isNotActive)
        {
            throw new BusinessException(BarcodeAreaMessages.LocalityIdNotActive);
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
    public BarcodeAreaBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public BarcodeAreaBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public BarcodeAreaBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public BarcodeAreaBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public BarcodeAreaBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public BarcodeAreaBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _barcodeAreaRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region BARCODEID RULES
    public BarcodeAreaBusinessRules CheckBarcodeIdExistence(Guid barcodeId)
    {
        var isExists = _barcodeRepository.Any(predicate: x => x.Id == barcodeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.BarcodeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodeAreaMessages.BarcodeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
