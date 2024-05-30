using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants.SiteOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;

public class CreateSiteCommand : IRequest<CreatedSiteResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSites";

    public CreateSiteDto Site { get; set; }
    public SitesDetailLevel DetailLevel { get; set; }


    public class CreateSiteCommandHandler : IRequestHandler<CreateSiteCommand, CreatedSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public CreateSiteCommandHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<CreatedSiteResponse> Handle(CreateSiteCommand request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Site.Code)
                .CheckDepositorIdsExistence(request.Site?.SiteDepositors?.Select(x => x.DepositorId)?.ToArray() ?? new Guid[0]);

            Site site = _mapper.Map<Site>(request.Site);
            site.Id = Guid.NewGuid();
            site.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            site.CreatedDate = DateTime.Now;
            site.SiteDepositors.ToList().ForEach(x => { x.CreatedDate = DateTime.Now; });

            await _siteRepository.AddAsync(site);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _siteRepository.GetAsync(predicate: x => x.Id == site.Id,
                include: x =>
                {
                    IQueryable<Site> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeBuilding)
                    {
                        query = query.Include(y => y.Buildings);
                    }

                    if (detailLevel.IncludeSiteDepositor)
                    {
                        query = query.Include(y => y.SiteDepositors);

                        if (detailLevel.SiteDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.SiteDepositors).ThenInclude(y => y.Depositor);
                        }
                    }


                    var includableQuery = query as IIncludableQueryable<Site, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSiteResponse>(response);
            }
            else
            {
                var response = await _siteRepository.GetAsync(predicate: x => x.Id == site.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSiteResponse>(response);
            }
        }
    }

}

