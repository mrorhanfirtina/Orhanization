using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants.CustomerOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Create;

public class CreateCustomerCommand : IRequest<CreatedCustomerResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetCustomers";

    public CreateCustomerDto Customer { get; set; }


    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CreatedCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, CustomerBusinessRules customerBusinessRules, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _customerBusinessRules = customerBusinessRules;
            _mapper = mapper;
        }

        public async Task<CreatedCustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _customerBusinessRules.CreateRequest()
            .CheckCodeExistenceWhenCreate(request.Customer.Code)
            .CheckCompanyIdExistence(request.Customer.CompanyId);

            Customer customer = _mapper.Map<Customer>(request.Customer);
            customer.Id = Guid.NewGuid();
            customer.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            customer.CreatedDate = DateTime.Now;
            customer.Address.Id = Guid.NewGuid();

            return _mapper.Map<CreatedCustomerResponse>(await _customerRepository.AddAsync(customer));
        }
    }
}
