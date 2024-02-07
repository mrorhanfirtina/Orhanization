using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;

public class DepositorBusinessRules : BaseBusinessRules
{
    private readonly IDepositorRepository _depositorRepository;

    public DepositorBusinessRules(IDepositorRepository depositorRepository)
    {
        _depositorRepository = depositorRepository;
    }

    //Depositor koduna ait kayıt mevcut mu? Aktif mi?
    public async Task<Depositor> DepositorCodeMustBeValid(string code)
    {
        Depositor? result = await _depositorRepository.GetAsync(withDeleted: true,predicate: d => d.Code == code);

        if (result == null)
        {
            throw new BusinessException(DepositorMessages.DepositorCodeNotExists);
        }
        else if(result.DeletedDate != null)
        {
            throw new BusinessException(DepositorMessages.DepositorCodeIsDeleted);
        }

        return result;
    }

    //Depositor koduna ait kayıt mevcut mu? Aktif mi?
    public async Task<Depositor> DepositorIdMustBeValid(Guid id)
    {
        Depositor? result = await _depositorRepository.GetAsync(withDeleted: true, predicate: d => d.Id == id);

        if (result == null)
        {
            throw new BusinessException(DepositorMessages.DepositorIdNotExists);
        }
        else if (result.DeletedDate != null)
        {
            throw new BusinessException(DepositorMessages.DepositorIdIsDeleted);
        }

        return result;
    }
}
