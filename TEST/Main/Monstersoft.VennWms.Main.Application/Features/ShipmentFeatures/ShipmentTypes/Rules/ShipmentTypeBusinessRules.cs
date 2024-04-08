using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Rules;

public class ShipmentTypeBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IShipmentTypeRepository _shipmentTypeRepository;
    private readonly IDepositorRepository _depositorRepository;
    public ShipmentTypeBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IShipmentTypeRepository shipmentTypeRepository, IDepositorRepository depositorRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _shipmentTypeRepository = shipmentTypeRepository;
        _depositorRepository = depositorRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ShipmentTypeBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ShipmentTypeMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ShipmentTypeMessages.LocalityIdNotActive);
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
    public ShipmentTypeBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ShipmentTypeBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ShipmentTypeBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ShipmentTypeBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ShipmentTypeBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ShipmentTypeBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _shipmentTypeRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public ShipmentTypeBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentTypeMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public ShipmentTypeBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _shipmentTypeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ShipmentTypeMessages.CodeExistsError);
            }
        }

        return this;
    }

    public ShipmentTypeBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _shipmentTypeRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ShipmentTypeMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}
