using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Rules;

public class BarcodeBusinessRules : BaseBusinessRules
{
    private readonly IBarcodeRepository _barcodeRepository;

    public BarcodeBusinessRules(IBarcodeRepository barcodeRepository)
    {
        _barcodeRepository = barcodeRepository;
    }

    //Barkod eklenirken mevcut mudiye ait aynı kodda başka barkod kaydı var mı?
    public async Task BarcodeCodeCannotBeDuplicatedWhenInsert(string code, Guid depositorId)
    {
        Barcode? result = await _barcodeRepository.GetAsync(predicate: p => p.Code.ToLower() == code.ToLower() 
                                                            && p.DepositorId == depositorId
                                                            && p.DeletedDate == null);

        if (result != null)
        {
            throw new BusinessException(BarcodeMessages.BarcodeCodeExists);
        }
    }

    //Update işlemleri için barkod kodu gerçekten var mı? Varsa barkod bilgisi dönülecek.
    public async Task<Barcode> BarcodeCodeMustBeValidWhenUpdate(string code, Guid depositorId)
    {
        Barcode? result = await _barcodeRepository.GetAsync(withDeleted: false, predicate: d => d.Code == code && d.DepositorId == depositorId);

        if (result == null)
        {
            throw new BusinessException(BarcodeMessages.BarcodeCodeNotExists);
        }
        else if (result.DeletedDate != null)
        {
            throw new BusinessException(BarcodeMessages.BarcodeCodeIsDeleted);
        }

        return result;
    }

    //Delete işlemleri için barkod kodu gerçekten var mı? Varsa barkod bilgisi dönülecek.
    public async Task<Barcode> BarcodeCodeMustBeValidWhenDelete(string code, Guid depositorId)
    {
        Barcode? result = await _barcodeRepository.GetAsync(withDeleted: false, predicate: d => d.Code == code && d.DepositorId == depositorId, enableTracking: false);

        if (result == null)
        {
            throw new BusinessException(BarcodeMessages.BarcodeCodeNotExists);
        }

        return result;
    }

    public async Task BarcodeCodeMustBeValid(string code, Guid depositorId)
    {
        var result = await _barcodeRepository.AnyAsync(predicate: d => d.Code == code && d.DepositorId == depositorId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(BarcodeMessages.BarcodeCodeNotExists);
        }
    }

    public async Task BarcodeIdMustBeValid(Guid barcodeId)
    {
        var result = await _barcodeRepository.AnyAsync(predicate: d => d.Id == barcodeId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(BarcodeMessages.BarcodeActiveIdNotExists);
        }
    }

    public async Task BarcodeIdMustBeValid(Guid barcodeId, Guid depositorId)
    {
        var result = await _barcodeRepository.AnyAsync(predicate: d => d.Id == barcodeId && d.DepositorId == depositorId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(BarcodeMessages.BarcodeActiveIdNotExists);
        }
    }

    public async Task IsDepositorHaveAnyBarcode(Guid depositorId)
    {
        var result = await _barcodeRepository.AnyAsync(predicate: d => d.DepositorId == depositorId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(BarcodeMessages.DepositorIsNotHaveBarcode);
        }
    }

}
