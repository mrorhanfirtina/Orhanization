using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;

public class ContainerUnitBusinessRules : BaseBusinessRules
{
    private readonly IContainerUnitRepository _containerUnitRepository;

    public ContainerUnitBusinessRules(IContainerUnitRepository containerUnitRepository)
    {
        _containerUnitRepository = containerUnitRepository;
    }



    //Konteyner birim eklenirken mevcut mudiye ait aynı kodda başka kayıt var mı?
    public async Task ContainerUnitCodeCannotBeDuplicatedWhenInsert(string code, Guid depositorId)
    {
        ContainerUnit? result = await _containerUnitRepository.GetAsync(predicate: p => p.Code.ToLower() == code.ToLower()
                                                            && p.DepositorId == depositorId
                                                            && p.DeletedDate == null);

        if (result != null)
        {
            throw new BusinessException(ContainerUnitMessages.ContainerUnitCodeExists);
        }
    }

    //Update işlemleri için barkod kodu gerçekten var mı? Varsa barkod bilgisi dönülecek.
    public async Task<ContainerUnit> ContainerUnitCodeMustBeValidWhenUpdate(string code, Guid depositorId)
    {
        ContainerUnit? result = await _containerUnitRepository.GetAsync(predicate: d => d.Code == code && d.DepositorId == depositorId && d.DeletedDate == null);

        if (result == null)
        {
            throw new BusinessException(ContainerUnitMessages.ContainerUnitCodeNotExists);
        }

        return result;
    }

    //Konteyner birim silinirken mevcut mudiye ait aynı kodda başka kayıt var mı?
    public async Task ContainerUnitCodeMustBeValidWhenDelete(string code, Guid depositorId)
    {
        var result = await _containerUnitRepository.AnyAsync(predicate: d => d.Code == code && d.DepositorId == depositorId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(ContainerUnitMessages.ContainerUnitCodeNotExists);
        }
    }

    //Konteyner birim koda ait kayıt var mı?
    public async Task IsContainerUnitCodeExists(string code, Guid depositorId)
    {
        var result = await _containerUnitRepository.AnyAsync(predicate: d => d.Code == code && d.DepositorId == depositorId && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(ContainerUnitMessages.ContainerUnitCodeNotExists);
        }
    }

    //Konteyner birim id ye ait kayıt var mı?
    public async Task IsContainerUnitIdExists(int id)
    {
        var result = await _containerUnitRepository.AnyAsync(predicate: d => d.Id == id && d.DeletedDate == null);

        if (!result)
        {
            throw new BusinessException(ContainerUnitMessages.ContainerUnitIdNotExists);
        }
    }
}
