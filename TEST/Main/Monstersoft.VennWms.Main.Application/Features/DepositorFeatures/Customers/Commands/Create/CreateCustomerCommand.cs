using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
    public CustomersDetailLevel DetailLevel { get; set; }


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
            .CheckDepositorCompany(request.UserRequestInfo!.RequestUserLocalityId)
            .CheckCodeExistenceWhenCreate(request.Customer.Code)
            .CheckCompanyIdExistence(request.Customer.CompanyId);

            Customer customer = _mapper.Map<Customer>(request.Customer);
            customer.Id = Guid.NewGuid();
            customer.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            customer.CreatedDate = DateTime.Now;

            await _customerRepository.AddAsync(customer);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _customerRepository.GetAsync(predicate: x => x.Id == customer.Id,
                include: x =>
                {
                    IQueryable<Customer> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeCompany)
                    {
                        query = query.Include(y => y.Company);
                    }

                    if (detailLevel.IncludeAddress)
                    {
                        query = query.Include(y => y.Address);
                    }

                    if (detailLevel.IncludeReceiver)
                    {
                        query = query.Include(y => y.Receivers);
                    }


                    var includableQuery = query as IIncludableQueryable<Customer, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedCustomerResponse>(response);
            }
            else
            {
                var response = await _customerRepository.GetAsync(predicate: x => x.Id == customer.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedCustomerResponse>(response);

            }
        }
    }
}
