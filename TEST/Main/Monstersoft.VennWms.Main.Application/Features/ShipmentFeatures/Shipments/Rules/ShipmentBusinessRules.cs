using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Rules;

public class ShipmentBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IShipmentRepository _shipmentRepository;
    private readonly IShipmentTypeRepository _shipmentTypeRepository;
    private readonly IDistributorRepository _disturbitorRepository;
    private readonly IDepositorRepository _depositorRepository;
    private readonly IBranchRepository _branchRepository;
    public ShipmentBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IShipmentRepository shipmentRepository, IShipmentTypeRepository shipmentTypeRepository, IDistributorRepository disturbitorRepository, IDepositorRepository depositorRepository, IBranchRepository branchRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _shipmentRepository = shipmentRepository;
        _shipmentTypeRepository = shipmentTypeRepository;
        _disturbitorRepository = disturbitorRepository;
        _depositorRepository = depositorRepository;
        _branchRepository = branchRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public ShipmentBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(ShipmentMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(ShipmentMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(ShipmentMessages.LocalityIdNotActive);
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
    public ShipmentBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public ShipmentBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public ShipmentBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public ShipmentBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public ShipmentBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public ShipmentBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _shipmentRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(ShipmentMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(ShipmentMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(ShipmentMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region BRANCHID RULES
    public ShipmentBusinessRules CheckBranchIdExistence(Guid branchId)
    {
        var isExists = _branchRepository.Any(predicate: x => x.Id == branchId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentMessages.BranchIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentMessages.BranchIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region SHIPMENTTYPEID RULES
    public ShipmentBusinessRules CheckShipmentTypeIdExistence(Guid shipmentTypeId)
    {
        var isExists = _shipmentTypeRepository.Any(predicate: x => x.Id == shipmentTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public ShipmentBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentMessages.DistirbutorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentMessages.DistirbutorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DISTIRBUTORID RULES
    public ShipmentBusinessRules CheckDistirbutorIdExistence(Guid distirbutorId)
    {
        var isExists = _disturbitorRepository.Any(predicate: x => x.Id == distirbutorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(ShipmentMessages.ShipmentTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(ShipmentMessages.ShipmentTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public ShipmentBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _shipmentRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ShipmentMessages.CodeExistsError);
            }
        }

        return this;
    }

    public ShipmentBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _shipmentRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(ShipmentMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}
