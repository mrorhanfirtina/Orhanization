using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Rules;

public class OperationClaimBusinessRules : BaseBusinessRules
{
    private readonly IOperationClaimRepository _operationClaimRepository;

    public OperationClaimBusinessRules(IOperationClaimRepository operationClaimRepository, IDepositorRepository depositorRepository)
    {
        _operationClaimRepository = operationClaimRepository;
    }

    public async Task OperationClaimIdShouldExistWhenSelected(int id)
    {
        OperationClaim? result = await _operationClaimRepository.GetAsync(predicate: b => b.Id == id, enableTracking: false);
        if (result == null)
            throw new BusinessException(OperationClaimsMessages.OperationClaimNotExists);
    }

    public async Task OperationClaimIdsShouldExistWhenSelected(int[] ids)
    {
        foreach (int id in ids)
        {
            bool result = await _operationClaimRepository.AnyAsync(predicate: b => b.Id == id && b.DeletedDate ==  null, enableTracking: false);
            if (!result)
                throw new BusinessException(OperationClaimsMessages.OperationClaimNotExists);
        }
    }
}
