using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;

public class UnsuitReasonBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IUnsuitReasonRepository _unsuitReasonRepository;
    private readonly IDepositorRepository _depositorRepository;
    public UnsuitReasonBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IUnsuitReasonRepository unsuitReasonRepository, IDepositorRepository depositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _unsuitReasonRepository = unsuitReasonRepository;
        _depositorRepository = depositorRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public UnsuitReasonBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(UnsuitReasonMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(UnsuitReasonMessages.LocalityIdNotActive);
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
    public UnsuitReasonBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public UnsuitReasonBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public UnsuitReasonBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public UnsuitReasonBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public UnsuitReasonBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public UnsuitReasonBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _unsuitReasonRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public UnsuitReasonBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(UnsuitReasonMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public UnsuitReasonBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _unsuitReasonRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(UnsuitReasonMessages.CodeExistsError);
            }
        }

        return this;
    }

    public UnsuitReasonBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _unsuitReasonRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(UnsuitReasonMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}