using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;

public class BarcodeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IBarcodeRepository _barcodeRepository;
    private readonly IPrinterRepository _printerRepository;
    private readonly IDepositorRepository _depositorRepository;
    public BarcodeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IBarcodeRepository barcodeRepository, 
        IDepositorRepository depositorRepository, IPrinterRepository printerRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _barcodeRepository = barcodeRepository;
        _depositorRepository = depositorRepository;
        _printerRepository = printerRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public BarcodeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(BarcodeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(BarcodeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(BarcodeMessages.LocalityIdNotActive);
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
    public BarcodeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public BarcodeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public BarcodeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public BarcodeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public BarcodeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public BarcodeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _barcodeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(BarcodeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(BarcodeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public BarcodeBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _barcodeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(BarcodeMessages.CodeExistsError);
            }
        }

        return this;
    }

    public BarcodeBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _barcodeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(BarcodeMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

    #region PRINTERID RULES
    public BarcodeBusinessRules CheckPrinterIdExistence(Guid printerId)
    {
        var isExists = _printerRepository.Any(predicate: x => x.Id == printerId 
        && x.DepositorCompanyId == DepositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(BarcodeMessages.PrinterIdNotExistsError);
        }

        return this;
    }

    public BarcodeBusinessRules CheckPrinterIdIsDuplicateInRequest(Guid[] printerIds)
    {
        if (printerIds != null && printerIds.Any())
        {
            var isDuplicate = printerIds.GroupBy(x => x).Any(g => g.Count() > 1);

            if (isDuplicate)
            {
                throw new BusinessException(BarcodeMessages.PrinterIdDuplicateError);
            }
        }

        return this;
    }
    #endregion
}
