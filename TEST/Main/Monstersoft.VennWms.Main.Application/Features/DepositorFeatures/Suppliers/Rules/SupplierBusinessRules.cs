using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Rules;

public class SupplierBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ISupplierRepository _supplierRepository;
    private readonly ICompanyRepository _companyRepository;
    private readonly IAddressRepository _addressRepository;
    public SupplierBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ISupplierRepository supplierRepository, ICompanyRepository companyRepository, IAddressRepository addressRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _supplierRepository = supplierRepository;
        _companyRepository = companyRepository;
        _addressRepository = addressRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public SupplierBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(SupplierMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(SupplierMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(SupplierMessages.LocalityIdNotActive);
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
    public SupplierBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public SupplierBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public SupplierBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public SupplierBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public SupplierBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public SupplierBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _supplierRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(SupplierMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(SupplierMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(SupplierMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(SupplierMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ADDRESSID RULES
    public SupplierBusinessRules CheckAddressIdExistence(Guid addressId)
    {
        var isExists = _addressRepository.Any(predicate: x => x.Id == addressId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(SupplierMessages.AddressIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(SupplierMessages.AddressIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region COMPANYID RULES
    public SupplierBusinessRules CheckCompanyIdExistence(Guid companyId)
    {
        var isExists = _companyRepository.Any(predicate: x => x.Id == companyId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(SupplierMessages.CompanyIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(SupplierMessages.CompanyIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public SupplierBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _supplierRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(SupplierMessages.CodeExistsError);
            }
        }

        return this;
    }

    public SupplierBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _supplierRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(SupplierMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}