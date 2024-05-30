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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants.SiteDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Queries.GetById;

public class GetByIdSiteDepositorQuery : IRequest<GetByIdSiteDepositorResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }
    public SiteDepositorsDetailLevel DetailLevel { get; set; }

    public class GetByIdSiteDepositorQueryHandler : IRequestHandler<GetByIdSiteDepositorQuery, GetByIdSiteDepositorResponse>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdSiteDepositorQueryHandler(ISiteDepositorRepository siteDepositorRepository, IMapper mapper, SiteDepositorBusinessRules siteDepositorBusinessRules)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _mapper = mapper;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
        }

        public async Task<GetByIdSiteDepositorResponse> Handle(GetByIdSiteDepositorQuery request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdSiteDepositorResponse>(await _siteDepositorRepository.GetAsync(x => x.Id == request.Id,
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
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdSiteDepositorResponse>(await _siteDepositorRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}

