using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants.CustomerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetList;

public class GetListCustomerQuery : IRequest<GetListResponse<GetListCustomerListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListCustomerQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetCustomers";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListCustomerQueryHandler : IRequestHandler<GetListCustomerQuery, GetListResponse<GetListCustomerListItemDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public GetListCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<GetListResponse<GetListCustomerListItemDto>> Handle(GetListCustomerQuery request, CancellationToken cancellationToken)
        {
            _customerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Customer> customerList = await _customerRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListCustomerListItemDto>>(customerList);
        }
    }

}
