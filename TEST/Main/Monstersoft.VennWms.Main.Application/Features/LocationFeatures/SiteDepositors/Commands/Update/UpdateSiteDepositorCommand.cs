using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Rules;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Update;

public class UpdateSiteDepositorCommand : IRequest<UpdatedSiteDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, SiteDepositorOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSiteDepositors";

    public UpdateSiteDepositorDto SiteDepositor { get; set; }
    public SiteDepositorDetailLevel DetailLevel { get; set; }

    public class UpdateSiteDepositorCommandHandler : IRequestHandler<UpdateSiteDepositorCommand, UpdatedSiteDepositorResponse>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;
        private readonly IMapper _mapper;

        public UpdateSiteDepositorCommandHandler(ISiteDepositorRepository siteDepositorRepository, SiteDepositorBusinessRules siteDepositorBusinessRules, IMapper mapper)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedSiteDepositorResponse> Handle(UpdateSiteDepositorCommand request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.SiteDepositor.Id)
            .CheckSiteIdExistence(request.SiteDepositor.SiteId)
            .CheckDepositorIdExistence(request.SiteDepositor.DepositorId);

            SiteDepositor? currentSiteDepositor = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == request.SiteDepositor.Id);

            SiteDepositor? siteDepositor = _mapper.Map(request.SiteDepositor, currentSiteDepositor);
            siteDepositor.UpdatedDate = DateTime.Now;

            await _siteDepositorRepository.UpdateAsync(siteDepositor);

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

                return _mapper.Map<UpdatedSiteDepositorResponse>(response);
            }
            else
            {
                var response = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == siteDepositor.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedSiteDepositorResponse>(response);
            }
        }
    }
}

