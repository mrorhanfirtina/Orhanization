using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants.SiteOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetList;

public class GetListSiteQuery : IRequest<GetListResponse<GetListSiteListItemDto>>, ICachableRequest, ITransactionalRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string CacheKey => $"GetListSiteQuery({PageRequest.PageIndex},{PageRequest.PageSize})";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetSites";
    public TimeSpan? SlidingExpiration { get; }

    public PageRequest PageRequest { get; set; }


    public class GetListSiteQueryHandler : IRequestHandler<GetListSiteQuery, GetListResponse<GetListSiteListItemDto>>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public GetListSiteQueryHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<GetListResponse<GetListSiteListItemDto>> Handle(GetListSiteQuery request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Site> siteList = await _siteRepository.GetListAsync(
            predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(y => y.SiteDepositors),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListSiteListItemDto>>(siteList);
        }
    }

}

