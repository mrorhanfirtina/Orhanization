using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Rules;

public class ShipmentAttributeValueBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IShipmentAttributeValueRepository _shipmentAttributeValueRepository;
    private readonly IShipmentRepository _shipmentRepository;
    private readonly IShipmentAttributeRepository _shipmentAttributeRepository;
    public ShipmentAttributeValueBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IShipmentAttributeValueRepository shipmentAttributeValueRepository, IShipmentRepository shipmentRepository, IShipmentAttributeRepository shipmentAttributeRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _shipmentAttributeValueRepository = shipmentAttributeValueRepository;
        _shipmentRepository = shipmentRepository;
        _shipmentAttributeRepository = shipmentAttributeRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ShipmentAttributeValueBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.LocalityIdNotActive);
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
    public ShipmentAttributeValueBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ShipmentAttributeValueBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ShipmentAttributeValueBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ShipmentAttributeValueBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ShipmentAttributeValueBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ShipmentAttributeValueBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _shipmentAttributeValueRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region SHIPMENTATTRIBUTEID RULES
    public ShipmentAttributeValueBusinessRules CheckShipmentAttributeIdExistence(Guid shipmentAttributeId)
    {
        var isExists = _shipmentAttributeRepository.Any(predicate: x => x.Id == shipmentAttributeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.ShipmentAttributeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.ShipmentAttributeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region SHIPMENTID RULES
    public ShipmentAttributeValueBusinessRules CheckShipmentIdExistence(Guid shipmentId)
    {
        var isExists = _shipmentRepository.Any(predicate: x => x.Id == shipmentId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.ShipmentIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentAttributeValueMessages.ShipmentIdNotExistsError);
        }

        return this;
    }
    #endregion

}
