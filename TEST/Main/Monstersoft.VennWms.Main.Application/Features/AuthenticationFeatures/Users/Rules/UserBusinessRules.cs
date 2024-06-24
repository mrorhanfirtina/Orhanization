using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Constants;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Constants;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.Hashing;
using System.Text.RegularExpressions;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Rules;

public class UserBusinessRules : BaseBusinessRules
{
    private readonly IUserRepository _userRepository;
    private readonly IDepositorRepository _depositorRepository;

    public UserBusinessRules(IUserRepository userRepository, IDepositorRepository depositorRepository)
    {
        _userRepository = userRepository;
        _depositorRepository = depositorRepository;
    }

    public async Task UserIdShouldExistWhenSelected(int id)
    {
        User? result = await _userRepository.GetAsync(predicate: b => b.Id == id, enableTracking: false);
        if (result == null)
            throw new BusinessException(AuthMessages.UserDontExists);
    }

    public Task UserShouldBeExist(User? user)
    {
        if (user is null)
            throw new BusinessException(AuthMessages.UserDontExists);
        return Task.CompletedTask;
    }

    public Task UserPasswordShouldBeMatch(User user, string password)
    {
        if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            throw new BusinessException(AuthMessages.PasswordDontMatch);
        return Task.CompletedTask;
    }

    public Task EmailShouldBeUnique(string email)
    {
        User? result = _userRepository.Get(predicate: b => b.Email == email, enableTracking: false);
        if (result != null)
            throw new BusinessException(AuthMessages.EmailAlreadyExists);
        return Task.CompletedTask;
    }

    public Task PasswordShouldBeStrong(string password)
    {
        // Define the regular expression for a strong password
        // Criteria:
        // - At least 8 characters
        // - Contains at least one uppercase letter
        // - Contains at least one lowercase letter
        // - Contains at least one digit
        // - Contains at least one special character (e.g., !@#$%^&*())
        var strongPasswordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()]).{8,}$");

        // Check if the password matches the regular expression
        bool isStrong = strongPasswordRegex.IsMatch(password);

        if (!isStrong)
            throw new BusinessException(UserMessages.PasswordIsNotStrong);
        return Task.CompletedTask;
    }

    public async Task DepositorIdsShouldExistWhenSelected(Guid[] ids)
    {
        foreach (Guid id in ids)
        {
            bool result = await _depositorRepository.AnyAsync(predicate: b => b.Id == id && b.DeletedDate == null, enableTracking: false);
            if (!result)
                throw new BusinessException(OperationClaimsMessages.DepositorNotExists);
        }
    }
}
