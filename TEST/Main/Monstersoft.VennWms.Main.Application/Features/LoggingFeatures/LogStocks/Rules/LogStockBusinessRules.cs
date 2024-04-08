using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Constants;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Rules;

public class LogStockBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILogStockRepository _logStockRepository;
    private readonly ITransactionTypeRepository _transactionTypeRepository;
    private readonly ITransactionLogRepository _transactionLogRepository;
    private readonly ILocationRepository _locationRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IProductRepository _productRepository;
    public LogStockBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILogStockRepository logStockRepository, ITransactionTypeRepository transactionTypeRepository, ITransactionLogRepository transactionLogRepository, IStockRepository stockRepository, IProductRepository productRepository, ILocationRepository locationRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _logStockRepository = logStockRepository;
        _transactionTypeRepository = transactionTypeRepository;
        _transactionLogRepository = transactionLogRepository;
        _locationRepository = locationRepository;
        _stockRepository = stockRepository;
        _productRepository = productRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LogStockBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LogStockMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LogStockMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LogStockMessages.LocalityIdNotActive);
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
    public LogStockBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LogStockBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LogStockBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LogStockBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LogStockBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LogStockBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _logStockRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LogStockMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LogStockMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LogStockMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region FROMLOCAITONID RULES
    public LogStockBusinessRules CheckFromLocaitonIdExistence(Guid fromLocaitonId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == fromLocaitonId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockMessages.FromLocaitonIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.FromLocaitonIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTID RULES
    public LogStockBusinessRules CheckProductIdExistence(Guid productId)
    {
        var isExists = _productRepository.Any(predicate: x => x.Id == productId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockMessages.ProductIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.ProductIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public LogStockBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockContainerMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TOLOCATIONID RULES
    public LogStockBusinessRules CheckToLocationIdExistence(Guid toLocationId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == toLocationId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockMessages.ToLocationIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.ToLocationIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TRANSACTIONLOGID RULES
    public LogStockBusinessRules CheckTransactionLogIdExistence(Guid transactionLogId)
    {
        var isExists = _transactionLogRepository.Any(predicate: x => x.Id == transactionLogId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockMessages.TransactionLogIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.TransactionLogIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region TRANSACTIONTYPEID RULES
    public LogStockBusinessRules CheckTransactionTypeIdExistence(int transactionTypeId)
    {
        var isExists = _transactionTypeRepository.Any(predicate: x => x.Id == transactionTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LogStockMessages.TransactionTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LogStockMessages.TransactionTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
