using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Constants.BranchOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetListByDynamic;

public class GetListByDynamicBranchQuery : IRequest<GetListResponse<GetListByDynamicBranchListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicBranchQueryHandler : IRequestHandler<GetListByDynamicBranchQuery, GetListResponse<GetListByDynamicBranchListItemDto>>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly BranchBusinessRules _branchBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicBranchQueryHandler(IBranchRepository branchRepository, IMapper mapper, BranchBusinessRules branchBusinessRules)
        {
            _branchRepository = branchRepository;
            _branchBusinessRules = branchBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicBranchListItemDto>> Handle(GetListByDynamicBranchQuery request, CancellationToken cancellationToken)
        {
            _branchBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Branch> branchList = await _branchRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicBranchListItemDto>>(branchList);
        }
    }

}
