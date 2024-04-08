using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.OrderRepositories;
using Monstersoft.VennWms.Main.Domain.Enums;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Rules;

public class OrderBusinessRules : BaseBusinessRules
{
    private readonly IDepositorCompanyRepository _depositorCompanyRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IStatusRepository _statusRepository;
    private readonly IReceiverRepository _receiverRepository;
    private readonly IOrderTypeRepository _orderTypeRepository;
    private readonly IDepositorRepository _depositorRepository;
    private readonly ICustomerRepository _customerRepository;
    public OrderBusinessRules(IDepositorCompanyRepository depositorCompanyRepository, IOrderRepository orderRepository, IStatusRepository statusRepository, IReceiverRepository receiverRepository, IOrderTypeRepository orderTypeRepository, IDepositorRepository depositorRepository, ICustomerRepository customerRepository)
    {
        _depositorCompanyRepository = depositorCompanyRepository;
        _orderRepository = orderRepository;
        _statusRepository = statusRepository;
        _receiverRepository = receiverRepository;
        _orderTypeRepository = orderTypeRepository;
        _depositorRepository = depositorRepository;
        _customerRepository = customerRepository;
    }
    #region BASE RULES
    public RequestType CurrentRequest { get; set; } = RequestType.Null;
    public Guid DepositorCompanyId { get; set; } = Guid.Empty;

    // Burada depositorComapnyId yi miras alan siniflarda kullanmak için Guid e çevirip sakliyoruz.
    public OrderBusinessRules CheckDepositorCompany(string localityId)
    {
        Guid depositorCompanyId = Guid.Parse(localityId);

        if (depositorCompanyId == Guid.Empty)
        {
            throw new BusinessException(OrderMessages.EmptyLocalityId);
        }

        var isExists = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && !x.DeletedDate.HasValue);

        if (!isExists)
        {
            throw new BusinessException(OrderMessages.LocalityIdNotFound);
        }

        var isNotActive = _depositorCompanyRepository.Any(predicate: x => x.Id == depositorCompanyId && x.DeletedDate != null, withDeleted: true);

        if (isNotActive)
        {
            throw new BusinessException(OrderMessages.LocalityIdNotActive);
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
    public OrderBusinessRules GetRequest()
    {
        SetRequestType(RequestType.Get);
        return this;
    }

    // Istek tipini Create olarak ayarliyoruz.
    public OrderBusinessRules CreateRequest()
    {
        SetRequestType(RequestType.Create);
        return this;
    }

    // Istek tipini Update olarak ayarliyoruz.
    public OrderBusinessRules UpdateRequest()
    {
        SetRequestType(RequestType.Update);
        return this;
    }

    // Istek tipini Delete olarak ayarliyoruz.
    public OrderBusinessRules DeleteRequest()
    {
        SetRequestType(RequestType.Delete);
        return this;
    }

    // Istek tipini Null olarak ayarliyoruz.
    public OrderBusinessRules NullRequest()
    {
        SetRequestType(RequestType.Null);
        return this;
    }
    #endregion

    #region ID RULES
    public OrderBusinessRules CheckIdExistence(Guid id)
    {
        var isExists = _orderRepository.Any(predicate: x => x.Id == id && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && isExists)
        {
            throw new BusinessException(OrderMessages.IdExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Delete && !isExists)
        {
            throw new BusinessException(OrderMessages.IdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Get && !isExists)
        {
            throw new BusinessException(OrderMessages.IdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CUSTOMERID RULES
    public OrderBusinessRules CheckCustomerIdExistence(Guid customerId)
    {
        var isExists = _customerRepository.Any(predicate: x => x.Id == customerId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderMessages.CustomerIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.CustomerIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region DEPOSITORID RULES
    public OrderBusinessRules CheckDepositorIdExistence(Guid depositorId)
    {
        var isExists = _depositorRepository.Any(predicate: x => x.Id == depositorId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderMessages.DepositorIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.DepositorIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region ORDERTYPEID RULES
    public OrderBusinessRules CheckOrderTypeIdExistence(Guid orderTypeId)
    {
        var isExists = _orderTypeRepository.Any(predicate: x => x.Id == orderTypeId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderMessages.OrderTypeIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.OrderTypeIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region RECEIVERID RULES
    public OrderBusinessRules CheckReceiverIdExistence(Guid receiverId)
    {
        var isExists = _receiverRepository.Any(predicate: x => x.Id == receiverId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderMessages.ReceiverIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.ReceiverIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region STATUSID RULES
    public OrderBusinessRules CheckStatusIdExistence(int statusId)
    {
        var isExists = _statusRepository.Any(predicate: x => x.Id == statusId && !x.DeletedDate.HasValue);

        if (CurrentRequest == RequestType.Create && !isExists)
        {
            throw new BusinessException(OrderMessages.StatusIdNotExistsError);
        }
        else if (CurrentRequest == RequestType.Update && !isExists)
        {
            throw new BusinessException(OrderMessages.StatusIdNotExistsError);
        }

        return this;
    }
    #endregion

    #region CODE RULES
    public OrderBusinessRules CheckCodeExistenceWhenCreate(string code)
    {
        if (CurrentRequest == RequestType.Create)
        {
            var isExists = _orderRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(OrderMessages.CodeExistsError);
            }
        }

        return this;
    }

    public OrderBusinessRules CheckCodeExistenceWhenUpdate(string code, Guid id)
    {
        if (CurrentRequest == RequestType.Update)
        {
            var isExists = _orderRepository.Any(predicate: x => x.DepositorCompanyId == DepositorCompanyId && x.Code == code && x.Id != id && !x.DeletedDate.HasValue);
            if (isExists)
            {
                throw new BusinessException(OrderMessages.CodeExistsError);
            }
        }

        return this;
    }
    #endregion

}
