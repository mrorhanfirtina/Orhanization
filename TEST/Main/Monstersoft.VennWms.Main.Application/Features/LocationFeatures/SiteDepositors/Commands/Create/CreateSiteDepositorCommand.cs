using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants.SiteDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;

public class CreateSiteDepositorCommand : IRequest<CreatedSiteDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSiteDepositors";

    public CreateSiteDepositorDto SiteDepositor { get; set; }
    public SiteDepositorsDetailLevel DetailLevel { get; set; }


    public class CreateSiteDepositorCommandHandler : IRequestHandler<CreateSiteDepositorCommand, CreatedSiteDepositorResponse>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateSiteDepositorCommandHandler(ISiteDepositorRepository siteDepositorRepository, IMapper mapper, SiteDepositorBusinessRules siteDepositorBusinessRules)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _mapper = mapper;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
        }

        public async Task<CreatedSiteDepositorResponse> Handle(CreateSiteDepositorCommand request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckSiteIdExistence(request.SiteDepositor.SiteId)
                .CheckDepositorIdExistence(request.SiteDepositor.DepositorId);

            SiteDepositor siteDepositor = _mapper.Map<SiteDepositor>(request.SiteDepositor);
            siteDepositor.Id = Guid.NewGuid();
            siteDepositor.CreatedDate = DateTime.Now;

            await _siteDepositorRepository.AddAsync(siteDepositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == siteDepositor.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSiteDepositorResponse>(response);
            }
            else
            {
                var response = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == siteDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedSiteDepositorResponse>(response);
            }
        }
    }
}

