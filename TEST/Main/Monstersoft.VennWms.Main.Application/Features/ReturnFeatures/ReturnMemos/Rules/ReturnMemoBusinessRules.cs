using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Rules;

public class ReturnMemoBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReturnMemoRepository _returnMemoRepository;
    private readonly IReturnRepository _returnRepository;
    public ReturnMemoBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReturnMemoRepository returnMemoRepository, IReturnRepository returnRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _returnMemoRepository = returnMemoRepository;
        _returnRepository = returnRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReturnMemoBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReturnMemoMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReturnMemoMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReturnMemoMessages.LocalityIdNotActive);
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
    public ReturnMemoBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReturnMemoBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReturnMemoBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReturnMemoBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReturnMemoBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReturnMemoBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _returnMemoRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReturnMemoMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnMemoMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReturnMemoMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReturnMemoMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RETURNID RULES
    public ReturnMemoBusinessRules CheckReturnIdExistence(Guid returnId)
    {
        var isExists = _returnRepository.Any(predicate: x => x.Id == returnId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReturnMemoMessages.ReturnIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReturnMemoMessages.ReturnIdNotExistsError);
        }

        return this;
    }
    #endregion

}
