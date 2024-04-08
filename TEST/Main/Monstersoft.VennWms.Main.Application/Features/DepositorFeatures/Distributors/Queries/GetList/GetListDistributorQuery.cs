using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Constants.DistributorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetList;

public class GetListDistributorQuery : IRequest<GetListResponse<GetListDistributorListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListDisturbitorQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetDisturbitors";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListDisturbitorQueryHandler : IRequestHandler<GetListDistributorQuery, GetListResponse<GetListDistributorListItemDto>>
    {
        private readonly IDistributorRepository _disturbitorRepository;
        private readonly DistributorBusinessRules _disturbitorBusinessRules;
        private readonly IMapper _mapper;

        public GetListDisturbitorQueryHandler(IDistributorRepository disturbitorRepository, IMapper mapper, DistributorBusinessRules disturbitorBusinessRules)
        {
            _disturbitorRepository = disturbitorRepository;
            _mapper = mapper;
            _disturbitorBusinessRules = disturbitorBusinessRules;
        }

        public async Task<GetListResponse<GetListDistributorListItemDto>> Handle(GetListDistributorQuery request, CancellationToken cancellationToken)
        {
            _disturbitorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Distributor> disturbitorList = await _disturbitorRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: m => m.Include(m => m.Address),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListDistributorListItemDto>>(disturbitorList);
        }
    }

}

