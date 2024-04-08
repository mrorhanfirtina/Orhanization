using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants.SiteOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetListByDynamic;

public class GetListByDynamicSiteQuery : IRequest<GetListResponse<GetListByDynamicSiteListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicSiteQueryHandler : IRequestHandler<GetListByDynamicSiteQuery, GetListResponse<GetListByDynamicSiteListItemDto>>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSiteQueryHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _siteBusinessRules = siteBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSiteListItemDto>> Handle(GetListByDynamicSiteQuery request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<Site> siteList = await _siteRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            include: x => x.Include(y => y.SiteDepositors),
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicSiteListItemDto>>(siteList);
        }
    }

}

