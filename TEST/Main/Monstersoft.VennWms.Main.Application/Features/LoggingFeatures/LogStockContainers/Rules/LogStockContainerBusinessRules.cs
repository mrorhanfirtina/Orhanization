using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Rules;

public class LogStockContainerBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILogStockContainerRepository _logStockContainerRepository;
    private readonly IStockContainerRepository _stockContainerRepository;
    private readonly ILogStockRepository _logStockRepository;
    public LogStockContainerBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILogStockContainerRepository logStockContainerRepository, IStockContainerRepository stockContainerRepository, ILogStockRepository logStockRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _logStockContainerRepository = logStockContainerRepository;
        _stockContainerRepository = stockContainerRepository;
        _logStockRepository = logStockRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LogStockContainerBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LogStockContainerMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LogStockContainerMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LogStockContainerMessages.LocalityIdNotActive);
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
    public LogStockContainerBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LogStockContainerBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LogStockContainerBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LogStockContainerBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LogStockContainerBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LogStockContainerBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _logStockContainerRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LogStockContainerMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region FROMCONTAINERID RULES
    public LogStockContainerBusinessRules CheckFromContainerIdExistence(Guid fromContainerId)
    {
        var isExists = _stockContainerRepository.Any(predicate: x => x.Id == fromContainerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.FromContainerIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.FromContainerIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOGSTOCKID RULES
    public LogStockContainerBusinessRules CheckLogStockIdExistence(Guid logStockId)
    {
        var isExists = _logStockRepository.Any(predicate: x => x.Id == logStockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.LogStockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.LogStockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TOCONTAINERID RULES
    public LogStockContainerBusinessRules CheckToContainerIdExistence(Guid toContainerId)
    {
        var isExists = _stockContainerRepository.Any(predicate: x => x.Id == toContainerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.ToContainerIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.ToContainerIdNotExistsError);
        }

        return this;
    }
    #endregion

}
