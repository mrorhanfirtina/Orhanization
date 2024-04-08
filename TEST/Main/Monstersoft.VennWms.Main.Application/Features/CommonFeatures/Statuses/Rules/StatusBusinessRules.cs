﻿using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Rules;

public class StatusBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IStatusRepository _statusRepository;
    public StatusBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IStatusRepository statusRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _statusRepository = statusRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public StatusBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(StatusMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(StatusMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(StatusMessages.LocalityIdNotActive);
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
    public StatusBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public StatusBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public StatusBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public StatusBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public StatusBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public StatusBusinessRules CheckIdExistence(int id)
    {
        var isExists = _statusRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(StatusMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StatusMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(StatusMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

}
