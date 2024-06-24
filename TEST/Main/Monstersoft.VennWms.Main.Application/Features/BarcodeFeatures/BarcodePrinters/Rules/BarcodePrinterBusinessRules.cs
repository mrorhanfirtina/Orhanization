using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Rules;

public class BarcodePrinterBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IBarcodePrinterRepository _barcodePrinterRepository;
    private readonly IPrinterRepository _printerRepository;
    private readonly IBarcodeRepository _barcodeRepository;
    public BarcodePrinterBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IBarcodePrinterRepository barcodePrinterRepository, IPrinterRepository printerRepository, IBarcodeRepository barcodeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _barcodePrinterRepository = barcodePrinterRepository;
        _printerRepository = printerRepository;
        _barcodeRepository = barcodeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public BarcodePrinterBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(BarcodePrinterMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(BarcodePrinterMessages.LocalityIdNotActive);
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
    public BarcodePrinterBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public BarcodePrinterBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public BarcodePrinterBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public BarcodePrinterBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public BarcodePrinterBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public BarcodePrinterBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _barcodePrinterRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region BARCODEID RULES
    public BarcodePrinterBusinessRules CheckBarcodeIdExistence(Guid barcodeId)
    {
        var isExists = _barcodeRepository.Any(predicate: x => x.Id == barcodeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.BarcodeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.BarcodeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRINTERID RULES
    public BarcodePrinterBusinessRules CheckPrinterIdExistence(Guid printerId)
    {
        var isExists = _printerRepository.Any(predicate: x => x.Id == printerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.PrinterIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(BarcodePrinterMessages.PrinterIdNotExistsError);
        }

        return this;
    }

    public BarcodePrinterBusinessRules CheckAlreadyExistence(Guid printerId, Guid barcodeId, Guid? id = null)
    {
        if (CurrentRequest == RequestType.Update && id != null)
        {
            var isExists = _barcodePrinterRepository.Any(predicate: x => x.BarcodeId == barcodeId && x.Id != id
        && x.PrinterId == printerId && !x.DeletedDate.HasValue);

            if (isExists)
            {
                throw new BusinessException(BarcodePrinterMessages.RecordAlreadyExists);
            }
        }
        else if (CurrentRequest == RequestType.Create)
        {
            var isExists = _barcodePrinterRepository.Any(predicate: x => x.BarcodeId == barcodeId
        && x.PrinterId == printerId && !x.DeletedDate.HasValue);

            if (isExists)
            {
                throw new BusinessException(BarcodePrinterMessages.RecordAlreadyExists);
            }
        }

        

        return this;
    }
    #endregion

}
