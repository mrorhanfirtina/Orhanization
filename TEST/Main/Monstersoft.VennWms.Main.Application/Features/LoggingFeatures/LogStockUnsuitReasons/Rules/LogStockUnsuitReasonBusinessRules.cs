using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Rules;

public class LogStockUnsuitReasonBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILogStockUnsuitReasonRepository _logStockUnsuitReasonRepository;
    private readonly IUnsuitReasonRepository _unsuitResaonRepository;
    private readonly ILogStockRepository _logStockRepository;
    public LogStockUnsuitReasonBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILogStockUnsuitReasonRepository logStockUnsuitReasonRepository, ILogStockRepository logStockRepository, IUnsuitReasonRepository unsuitResaonRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _logStockUnsuitReasonRepository = logStockUnsuitReasonRepository;
        _logStockRepository = logStockRepository;
        _unsuitResaonRepository = unsuitResaonRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LogStockUnsuitReasonBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.LocalityIdNotActive);
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
    public LogStockUnsuitReasonBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LogStockUnsuitReasonBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LogStockUnsuitReasonBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LogStockUnsuitReasonBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LogStockUnsuitReasonBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LogStockUnsuitReasonBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _logStockUnsuitReasonRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region FROMRESAONID RULES
    public LogStockUnsuitReasonBusinessRules CheckFromResaonIdExistence(Guid fromResaonId)
    {
        var isExists = _unsuitResaonRepository.Any(predicate: x => x.Id == fromResaonId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.FromResaonIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.FromResaonIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOGSTOCKID RULES
    public LogStockUnsuitReasonBusinessRules CheckLogStockIdExistence(Guid logStockId)
    {
        var isExists = _logStockRepository.Any(predicate: x => x.Id == logStockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.LogStockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.LogStockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TORESAONID RULES
    public LogStockUnsuitReasonBusinessRules CheckToResaonIdExistence(Guid toResaonId)
    {
        var isExists = _unsuitResaonRepository.Any(predicate: x => x.Id == toResaonId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.ToResaonIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockUnsuitReasonMessages.ToResaonIdNotExistsError);
        }

        return this;
    }
    #endregion

}
