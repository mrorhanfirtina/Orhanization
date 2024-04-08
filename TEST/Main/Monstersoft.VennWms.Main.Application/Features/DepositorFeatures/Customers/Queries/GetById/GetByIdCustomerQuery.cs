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


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetById;

public class GetByIdCustomerQuery : IRequest<GetByIdCustomerResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdCustomerQueryHandler : IRequestHandler<GetByIdCustomerQuery, GetByIdCustomerResponse>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<GetByIdCustomerResponse> Handle(GetByIdCustomerQuery request, CancellationToken cancellationToken)
        {
            _customerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdCustomerResponse>(await _customerRepository.GetAsync(x => x.Id == request.Id,
                include: m => m.Include(m => m.Address),
                withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
