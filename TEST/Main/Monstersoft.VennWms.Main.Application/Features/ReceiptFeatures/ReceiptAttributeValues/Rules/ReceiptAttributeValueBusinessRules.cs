using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ReceiptRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Rules;

public class ReceiptAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReceiptAttributeValueRepository _receiptAttributeValueRepository;
    private readonly IReceiptRepository _receiptRepository;
    private readonly IReceiptAttributeRepository _receiptAttributeRepository;
    public ReceiptAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReceiptAttributeValueRepository receiptAttributeValueRepository, IReceiptRepository receiptRepository, IReceiptAttributeRepository receiptAttributeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _receiptAttributeValueRepository = receiptAttributeValueRepository;
        _receiptRepository = receiptRepository;
        _receiptAttributeRepository = receiptAttributeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReceiptAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.LocalityIdNotActive);
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
    public ReceiptAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReceiptAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReceiptAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReceiptAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReceiptAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReceiptAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _receiptAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RECEIPTATTRIBUTEID RULES
    public ReceiptAttributeValueBusinessRules CheckReceiptAttributeIdExistence(Guid receiptAttributeId)
    {
        var isExists = _receiptAttributeRepository.Any(predicate: x => x.Id == receiptAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.ReceiptAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.ReceiptAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RECEIPTID RULES
    public ReceiptAttributeValueBusinessRules CheckReceiptIdExistence(Guid receiptId)
    {
        var isExists = _receiptRepository.Any(predicate: x => x.Id == receiptId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.ReceiptIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiptAttributeValueMessages.ReceiptIdNotExistsError);
        }

        return this;
    }
    #endregion

}
