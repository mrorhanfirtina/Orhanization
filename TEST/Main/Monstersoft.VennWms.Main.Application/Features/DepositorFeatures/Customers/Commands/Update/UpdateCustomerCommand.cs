using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Update;

public class UpdateCustomerCommand : IRequest<UpdatedCustomerResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Write, CustomerOperationClaims.Update];
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetCustomers";

    public UpdateCustomerDto Customer { get; set; }


    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, UpdatedCustomerResponse>
    {
        private readonly ICustomerRepository _companyRepository;
        private readonly CustomerBusinessRules _companyBusinessRules;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(ICustomerRepository companyRepository, CustomerBusinessRules companyBusinessRules, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _companyBusinessRules = companyBusinessRules;
            _mapper = mapper;
        }
        public async Task<UpdatedCustomerResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            _companyBusinessRules.UpdateRequest()
                .CheckIdExistence(request.Customer.Id)
                .CheckAddressIdExistence(request.Customer.AddressId)
                .CheckCodeExistenceWhenUpdate(request.Customer.Code, request.Customer.Id);

            Customer currentCustomer = await _companyRepository.GetAsync(predicate: x => x.Id == request.Customer.Id && !x.DeletedDate.HasValue, include: x => x.Include(y => y.Address));

            Customer? customer = _mapper.Map(request.Customer, currentCustomer);
            customer.UpdatedDate = DateTime.Now;
            customer.Address.UpdatedDate = DateTime.Now;

            return _mapper.Map<UpdatedCustomerResponse>(await _companyRepository.UpdateAsync(customer));
        }
    }
}
