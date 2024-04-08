using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Rules;

public class ReceiptItemBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReceiptItemRepository _receiptItemRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly IReceiptRepository _receiptRepository;
    private readonly IProductRepository _productRepository;
    private readonly IItemUnitRepository _itemUnitRepository;
    public ReceiptItemBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReceiptItemRepository receiptItemRepository, IStatusRepository statusRepository, IReceiptRepository receiptRepository, IProductRepository productRepository, IItemUnitRepository itemUnitRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _receiptItemRepository = receiptItemRepository;
        _statusRepository = statusRepository;
        _receiptRepository = receiptRepository;
        _productRepository = productRepository;
        _itemUnitRepository = itemUnitRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReceiptItemBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReceiptItemMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReceiptItemMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReceiptItemMessages.LocalityIdNotActive);
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
    public ReceiptItemBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReceiptItemBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReceiptItemBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReceiptItemBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReceiptItemBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReceiptItemBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _receiptItemRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReceiptItemMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ITEMUNITID RULES
    public ReceiptItemBusinessRules CheckItemUnitIdExistence(Guid itemUnitId)
    {
        var isExists = _itemUnitRepository.Any(predicate: x => x.Id == itemUnitId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ItemUnitIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ItemUnitIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STATUSID RULES
    public ReceiptItemBusinessRules CheckStatusIdExistence(int statusId)
    {
        var isExists = _statusRepository.Any(predicate: x => x.Id == statusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ProductIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ProductIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTID RULES
    public ReceiptItemBusinessRules CheckProductIdExistence(Guid productId)
    {
        var isExists = _productRepository.Any(predicate: x => x.Id == productId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ReceiptIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.ReceiptIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RECEIPTID RULES
    public ReceiptItemBusinessRules CheckReceiptIdExistence(Guid receiptId)
    {
        var isExists = _receiptRepository.Any(predicate: x => x.Id == receiptId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.StatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptItemMessages.StatusIdNotExistsError);
        }

        return this;
    }
    #endregion

}
