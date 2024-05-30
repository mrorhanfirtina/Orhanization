using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Update;

public class UpdateSiteCommand : IRequest<UpdatedSiteResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, SiteOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSites";

    public UpdateSiteDto Site { get; set; }
    public SitesDetailLevel DetailLevel { get; set; }


    public class UpdateSiteCommandHandler : IRequestHandler<UpdateSiteCommand, UpdatedSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly IMapper _mapper;

        public UpdateSiteCommandHandler(ISiteRepository siteRepository, SiteBusinessRules siteBusinessRules, IMapper mapper, ISiteDepositorRepository siteDepositorRepository)
        {
            _siteRepository = siteRepository;
            _siteBusinessRules = siteBusinessRules;
            _mapper = mapper;
            _siteDepositorRepository = siteDepositorRepository;
        }

        public async Task<UpdatedSiteResponse> Handle(UpdateSiteCommand request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Site.Id)
            .CheckCodeExistenceWhenUpdate(request.Site.Code, request.Site.Id)
            .CheckDepositorIdsExistence(request.Site?.SiteDepositors?.Select(x => x.DepositorId)?.ToArray() ?? new Guid[0]);

            Site? currentSite = await _siteRepository.GetAsync(predicate: x => x.Id == request.Site.Id, 
            include: x => x.Include(y => y.SiteDepositors)
                           .Include(y => y.SiteDepositors).ThenInclude(m => m.Depositor)
                           .Include(y => y.SiteDepositors).ThenInclude(m => m.Depositor).ThenInclude(p => p.Company));

            await _siteDepositorRepository.DeleteRangeAsync(currentSite.SiteDepositors, permanent: true);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Site? site = _mapper.Map(request.Site, currentSite);
            site.UpdatedDate = DateTime.Now;

            site.SiteDepositors.ToList().ForEach(x => { x.CreatedDate = site.CreatedDate; x.UpdatedDate = DateTime.Now; });

            await _siteRepository.UpdateAsync(site);


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

                return _mapper.Map<UpdatedSiteResponse>(response);
            }
            else
            {
                var response = await _siteRepository.GetAsync(predicate: x => x.Id == site.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSiteResponse>(response);
            }
        }
    }
}

