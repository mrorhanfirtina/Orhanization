using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Rules;

public class LocationProductAttributeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly ILocationProductAttributeRepository _locationProductAttributeRepository;
    private readonly IProductAttributeRepository _productAttributeRepository;
    private readonly ILocationRepository _locationRepository;
    public LocationProductAttributeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, ILocationProductAttributeRepository locationProductAttributeRepository, IProductAttributeRepository productAttributeRepository, ILocationRepository locationRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _locationProductAttributeRepository = locationProductAttributeRepository;
        _productAttributeRepository = productAttributeRepository;
        _locationRepository = locationRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public LocationProductAttributeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(LocationProductAttributeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(LocationProductAttributeMessages.LocalityIdNotActive);
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
    public LocationProductAttributeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public LocationProductAttributeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public LocationProductAttributeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public LocationProductAttributeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public LocationProductAttributeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public LocationProductAttributeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _locationProductAttributeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region LOCATIONID RULES
    public LocationProductAttributeBusinessRules CheckLocationIdExistence(Guid locationId)
    {
        var isExists = _locationRepository.Any(predicate: x => x.Id == locationId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.LocationIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.LocationIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTATTRIBUTEID RULES
    public LocationProductAttributeBusinessRules CheckProductAttributeIdExistence(Guid productAttributeId)
    {
        var isExists = _productAttributeRepository.Any(predicate: x => x.Id == productAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.ProductAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(LocationProductAttributeMessages.ProductAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

}
