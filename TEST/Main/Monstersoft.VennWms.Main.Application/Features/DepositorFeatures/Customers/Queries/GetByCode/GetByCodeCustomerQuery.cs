using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants.CustomerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetByCode;

public class GetByCodeCustomerQuery : IRequest<GetByCodeCustomerResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeCustomerQueryHandler : IRequestHandler<GetByCodeCustomerQuery, GetByCodeCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<GetByCodeCustomerResponse> Handle(GetByCodeCustomerQuery request, CancellationToken cancellationToken)
        {
            _customerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeCustomerResponse>(await _customerRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
