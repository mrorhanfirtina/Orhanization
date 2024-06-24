using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.StockRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Rules;

public class ReceiptItmStockAttrValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReceiptItmStockAttrValueRepository _receiptItmStockAttrValueRepository;
    private readonly IStockAttributeRepository _stockAttributeRepository;
    private readonly IReceiptItemRepository _receiptItemRepository;
    public ReceiptItmStockAttrValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReceiptItmStockAttrValueRepository receiptItmStockAttrValueRepository, IStockAttributeRepository stockAttributeRepository, IReceiptItemRepository receiptItemRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _receiptItmStockAttrValueRepository = receiptItmStockAttrValueRepository;
        _stockAttributeRepository = stockAttributeRepository;
        _receiptItemRepository = receiptItemRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReceiptItmStockAttrValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.LocalityIdNotActive);
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
    public ReceiptItmStockAttrValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReceiptItmStockAttrValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReceiptItmStockAttrValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReceiptItmStockAttrValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReceiptItmStockAttrValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReceiptItmStockAttrValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _receiptItmStockAttrValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RECEIPTITEMID RULES
    public ReceiptItmStockAttrValueBusinessRules CheckReceiptItemIdExistence(Guid receiptItemId)
    {
        var isExists = _receiptItemRepository.Any(predicate: x => x.Id == receiptItemId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.ReceiptItemIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.ReceiptItemIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STOCKATTRIBUTEID RULES
    public ReceiptItmStockAttrValueBusinessRules CheckStockAttributeIdExistence(Guid stockAttributeId)
    {
        var isExists = _stockAttributeRepository.Any(predicate: x => x.Id == stockAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.StockAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItmStockAttrValueMessages.StockAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
