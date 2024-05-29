using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants.SiteOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Queries.GetById;

public class GetByIdSiteQuery : IRequest<GetByIdSiteResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public SiteDetailLevel DetailLevel { get; set; }


    public class GetByIdSiteQueryHandler : IRequestHandler<GetByIdSiteQuery, GetByIdSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSiteQueryHandler(ISiteRepository siteRepository, IMapper mapper, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _mapper = mapper;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<GetByIdSiteResponse> Handle(GetByIdSiteQuery request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdSiteResponse>(await _siteRepository.GetAsync(x => x.Id == request.Id,
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
                },
                enableTracking: false, withDeleted: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdSiteResponse>(await _siteRepository.GetAsync(x => x.Id == request.Id,
                enableTracking: false, withDeleted: false, cancellationToken: cancellationToken));
            }
        }
    }

}

