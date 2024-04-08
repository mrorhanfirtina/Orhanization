using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Rules;

public class LogStockReserveReasonBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILogStockReserveReasonRepository _logStockReserveReasonRepository;
    private readonly ILogStockRepository _logStockRepository;
    public LogStockReserveReasonBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILogStockReserveReasonRepository logStockReserveReasonRepository, ILogStockRepository logStockRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _logStockReserveReasonRepository = logStockReserveReasonRepository;
        _logStockRepository = logStockRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LogStockReserveReasonBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LogStockReserveReasonMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LogStockReserveReasonMessages.LocalityIdNotActive);
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
    public LogStockReserveReasonBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LogStockReserveReasonBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LogStockReserveReasonBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LogStockReserveReasonBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LogStockReserveReasonBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LogStockReserveReasonBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _logStockReserveReasonRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOGSTOCKID RULES
    public LogStockReserveReasonBusinessRules CheckLogStockIdExistence(Guid logStockId)
    {
        var isExists = _logStockRepository.Any(predicate: x => x.Id == logStockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.LogStockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockReserveReasonMessages.LogStockIdNotExistsError);
        }

        return this;
    }
    #endregion

}
