using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants;
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
    public CustomerDetailLevel DetailLevel { get; set; }


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
            },
            index: request.PageRequest.PageIndex, enableTracking: false,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicCustomerListItemDto>>(customerList);
        }
    }

}
