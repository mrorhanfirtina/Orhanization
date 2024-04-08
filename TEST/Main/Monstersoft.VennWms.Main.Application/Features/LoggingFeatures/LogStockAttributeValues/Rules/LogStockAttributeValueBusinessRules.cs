using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Rules;

public class LogStockAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILogStockAttributeValueRepository _logStockAttributeValueRepository;
    private readonly IStockAttributeRepository _stockAttributeRepository;
    private readonly ILogStockRepository _logStockRepository;
    public LogStockAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILogStockAttributeValueRepository logStockAttributeValueRepository, IStockAttributeRepository stockAttributeRepository, ILogStockRepository logStockRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _logStockAttributeValueRepository = logStockAttributeValueRepository;
        _stockAttributeRepository = stockAttributeRepository;
        _logStockRepository = logStockRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LogStockAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LogStockAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LogStockAttributeValueMessages.LocalityIdNotActive);
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
    public LogStockAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LogStockAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LogStockAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LogStockAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LogStockAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LogStockAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _logStockAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOGSTOCKID RULES
    public LogStockAttributeValueBusinessRules CheckLogStockIdExistence(Guid logStockId)
    {
        var isExists = _logStockRepository.Any(predicate: x => x.Id == logStockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.LogStockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.LogStockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKATTRIBUTEID RULES
    public LogStockAttributeValueBusinessRules CheckStockAttributeIdExistence(Guid stockAttributeId)
    {
        var isExists = _stockAttributeRepository.Any(predicate: x => x.Id == stockAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.StockAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockAttributeValueMessages.StockAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
