using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.UserOperationClaims.Rules;

public class UserOperationClaimBusinessRules : BaseBusinessRules
{
    private readonly IUserOperationClaimRepository _userOperationClaimRepository;

    public UserOperationClaimBusinessRules(IUserOperationClaimRepository userOperationClaimRepository)
    {
        _userOperationClaimRepository = userOperationClaimRepository;
    }

    public async Task UserOperationClaimIdShouldExistWhenSelected(int id)
    {
        UserOperationClaim? result = await _userOperationClaimRepository.GetAsync(predicate: b => b.Id == id, enableTracking: false);
        if (result == null)
            throw new BusinessException(UserOperationClaimsMessages.UserOperationClaimNotExists);
    }
}