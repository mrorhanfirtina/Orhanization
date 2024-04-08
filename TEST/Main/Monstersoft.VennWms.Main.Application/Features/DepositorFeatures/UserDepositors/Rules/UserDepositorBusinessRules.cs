using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Rules;

public class UserDepositorBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IUserDepositorRepository _userDepositorRepository;
    private readonly IDepositorRepository _depositorRepository;
    private readonly IUserRepository _userRepository;
    public UserDepositorBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IUserDepositorRepository userDepositorRepository, IUserRepository userRepository, IDepositorRepository depositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _userDepositorRepository = userDepositorRepository;
        _userRepository = userRepository;
        _depositorRepository = depositorRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public UserDepositorBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(UserDepositorMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(UserDepositorMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(UserDepositorMessages.LocalityIdNotActive);
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
    public UserDepositorBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public UserDepositorBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public UserDepositorBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public UserDepositorBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public UserDepositorBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public UserDepositorBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _userDepositorRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(UserDepositorMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region USERID RULES
    public UserDepositorBusinessRules CheckUserIdExistence(int userId)
    {
        var isExists = _userRepository.Any(predicate: x => x.Id == userId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.UserIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.UserIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public UserDepositorBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(UserDepositorMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

}
