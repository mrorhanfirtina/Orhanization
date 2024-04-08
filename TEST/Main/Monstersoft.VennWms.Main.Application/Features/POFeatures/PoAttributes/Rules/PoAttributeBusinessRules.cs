using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.PORepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Rules;

public class PoAttributeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IPoAttributeRepository _poAttributeRepository;
    private readonly IDepositorRepository _depositorRepository;
    private readonly IAttributeInputTypeRepository _attributeInputTypeRepository;
    public PoAttributeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IPoAttributeRepository poAttributeRepository, IDepositorRepository depositorRepository, IAttributeInputTypeRepository attributeInputTypeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _poAttributeRepository = poAttributeRepository;
        _depositorRepository = depositorRepository;
        _attributeInputTypeRepository = attributeInputTypeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public PoAttributeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(PoAttributeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(PoAttributeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(PoAttributeMessages.LocalityIdNotActive);
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
    public PoAttributeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public PoAttributeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public PoAttributeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public PoAttributeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public PoAttributeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public PoAttributeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _poAttributeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(PoAttributeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ATTRIBUTEINPUTTYPEID RULES
    public PoAttributeBusinessRules CheckAttributeInputTypeIdExistence(int attributeInputTypeId)
    {
        var isExists = _attributeInputTypeRepository.Any(predicate: x => x.Id == attributeInputTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.AttributeInputTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.AttributeInputTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public PoAttributeBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(PoAttributeMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public PoAttributeBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _poAttributeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(PoAttributeMessages.CodeExistsError);
            }
        }

        return this;
    }

    public PoAttributeBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _poAttributeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(PoAttributeMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}
