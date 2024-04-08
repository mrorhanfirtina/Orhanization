using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Rules;

public class ReceiverBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IReceiverRepository _receiverRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IAddressRepository _addressRepository;
    public ReceiverBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IReceiverRepository receiverRepository, ICustomerRepository customerRepository, IAddressRepository addressRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _receiverRepository = receiverRepository;
        _customerRepository = customerRepository;
        _addressRepository = addressRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ReceiverBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ReceiverMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ReceiverMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ReceiverMessages.LocalityIdNotActive);
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
    public ReceiverBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ReceiverBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ReceiverBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ReceiverBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ReceiverBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ReceiverBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _receiverRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ReceiverMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiverMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ReceiverMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ReceiverMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ADDRESSID RULES
    public ReceiverBusinessRules CheckAddressIdExistence(Guid addressId)
    {
        var isExists = _addressRepository.Any(predicate: x => x.Id == addressId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiverMessages.AddressIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiverMessages.AddressIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CUSTOMERID RULES
    public ReceiverBusinessRules CheckCustomerIdExistence(Guid customerId)
    {
        var isExists = _customerRepository.Any(predicate: x => x.Id == customerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ReceiverMessages.CustomerIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ReceiverMessages.CustomerIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public ReceiverBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _receiverRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ReceiverMessages.CodeExistsError);
            }
        }

        return this;
    }

    public ReceiverBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _receiverRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ReceiverMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}
