using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Rules;

public class StockReserveReasonBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IStockReserveReasonRepository _stockReserveReasonRepository;
    private readonly IStockRepository _stockRepository;
    private readonly IReserveReasonRepository _reserveReasonRepository;
    public StockReserveReasonBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IStockReserveReasonRepository stockReserveReasonRepository, IStockRepository stockRepository, IReserveReasonRepository reserveReasonRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _stockReserveReasonRepository = stockReserveReasonRepository;
        _stockRepository = stockRepository;
        _reserveReasonRepository = reserveReasonRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public StockReserveReasonBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(StockReserveReasonMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(StockReserveReasonMessages.LocalityIdNotActive);
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
    public StockReserveReasonBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public StockReserveReasonBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public StockReserveReasonBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public StockReserveReasonBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public StockReserveReasonBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public StockReserveReasonBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _stockReserveReasonRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RESERVEREASONID RULES
    public StockReserveReasonBusinessRules CheckReserveReasonIdExistence(Guid reserveReasonId)
    {
        var isExists = _reserveReasonRepository.Any(predicate: x => x.Id == reserveReasonId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.ReserveReasonIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.ReserveReasonIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKID RULES
    public StockReserveReasonBusinessRules CheckStockIdExistence(Guid stockId)
    {
        var isExists = _stockRepository.Any(predicate: x => x.Id == stockId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.StockIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(StockReserveReasonMessages.StockIdNotExistsError);
        }

        return this;
    }
    #endregion

}
