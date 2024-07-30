using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;

public class ActionParameterBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IActionParameterRepository _actionParameterCategoryRepository;
    private readonly IUserDepositorRepository _userDepositorRepository;

    public ActionParameterBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IActionParameterRepository actionParameterCategoryRepository, IUserDepositorRepository userDepositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _actionParameterCategoryRepository = actionParameterCategoryRepository;
        _userDepositorRepository = userDepositorRepository;
    }

    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ActionParameterBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ActionParameterMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ActionParameterMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ActionParameterMessages.LocalityIdNotActive);
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
    public ActionParameterBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ActionParameterBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ActionParameterBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ActionParameterBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ActionParameterBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ActionParameterBusinessRules CheckIdExistence(int id)
    {
        var isExists = _actionParameterCategoryRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ActionParameterMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ActionParameterMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ActionParameterMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ActionParameterMessages.IdNotExistsError);
        }

        return this;
    }

    public ActionParameterBusinessRules CheckDepositorId(int userId, Guid? depositorId = null)
    {
        if (CurrentRequest == RequestType.Get)
        {
            if (depositorId.HasValue)
            {
                var hasValue = _userDepositorRepository.Any(predicate: x => x.DepositorId == depositorId && x.UserId == userId && !x.DeletedDate.HasValue);

                if (!hasValue)
                {
                    throw new BusinessException(ActionParameterMessages.UserDepositorNotExists, "www.monstersoft.com/help/actionparameters");
                }

                return this;
            }
            return this;
        }
        return this;
    }
    #endregion
}
