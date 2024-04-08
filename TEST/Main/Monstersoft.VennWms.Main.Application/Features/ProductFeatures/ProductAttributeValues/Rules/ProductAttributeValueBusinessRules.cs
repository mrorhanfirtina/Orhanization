using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ProductRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Rules;

public class ProductAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IProductAttributeValueRepository _productAttributeValueRepository;
    private readonly IProductRepository _productRepository;
    private readonly IProductAttributeRepository _productAttributeRepository;
    public ProductAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IProductAttributeValueRepository productAttributeValueRepository, IProductRepository productRepository, IProductAttributeRepository productAttributeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _productAttributeValueRepository = productAttributeValueRepository;
        _productRepository = productRepository;
        _productAttributeRepository = productAttributeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ProductAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ProductAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ProductAttributeValueMessages.LocalityIdNotActive);
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
    public ProductAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ProductAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ProductAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ProductAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ProductAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ProductAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _productAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTATTRIBUTEID RULES
    public ProductAttributeValueBusinessRules CheckProductAttributeIdExistence(Guid productAttributeId)
    {
        var isExists = _productAttributeRepository.Any(predicate: x => x.Id == productAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.ProductAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.ProductAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region PRODUCTID RULES
    public ProductAttributeValueBusinessRules CheckProductIdExistence(Guid productId)
    {
        var isExists = _productRepository.Any(predicate: x => x.Id == productId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.ProductIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ProductAttributeValueMessages.ProductIdNotExistsError);
        }

        return this;
    }
    #endregion

}
