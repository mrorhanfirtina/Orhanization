using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants.CustomerOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetListByDynamic;

public class GetListByDynamicCustomerQuery : IRequest<GetListResponse<GetListByDynamicCustomerListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicCustomerQueryHandler : IRequestHandler<GetListByDynamicCustomerQuery, GetListResponse<GetListByDynamicCustomerListItemDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerBusinessRules _customerBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicCustomerQueryHandler(ICustomerRepository customerRepository, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerRepository = customerRepository;
            _customerBusinessRules = customerBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicCustomerListItemDto>> Handle(GetListByDynamicCustomerQuery request, CancellationToken cancellationToken)
        {
            _customerBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Customer> customerList = await _customerRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicCustomerListItemDto>>(customerList);
        }
    }

}
