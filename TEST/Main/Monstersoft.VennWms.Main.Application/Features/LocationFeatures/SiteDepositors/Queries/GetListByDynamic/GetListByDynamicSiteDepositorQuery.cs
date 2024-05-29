using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants.SiteDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetListByDynamic;

public class GetListByDynamicSiteDepositorQuery : IRequest<GetListResponse<GetListByDynamicSiteDepositorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public SiteDepositorDetailLevel DetailLevel { get; set; }

    public class GetListByDynamicSiteDepositorQueryHandler : IRequestHandler<GetListByDynamicSiteDepositorQuery, GetListResponse<GetListByDynamicSiteDepositorListItemDto>>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicSiteDepositorQueryHandler(ISiteDepositorRepository siteDepositorRepository, IMapper mapper, SiteDepositorBusinessRules siteDepositorBusinessRules)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicSiteDepositorListItemDto>> Handle(GetListByDynamicSiteDepositorQuery request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<SiteDepositor> siteDepositorList = await _siteDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<SiteDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeSite)
                    {
                        query = query.Include(y => y.Site);
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);
                    }


                    var includableQuery = query as IIncludableQueryable<SiteDepositor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSiteDepositorListItemDto>>(siteDepositorList);
            }
            else
            {
                Paginate<SiteDepositor> siteDepositorList = await _siteDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicSiteDepositorListItemDto>>(siteDepositorList);
            }
        }
    }
}

