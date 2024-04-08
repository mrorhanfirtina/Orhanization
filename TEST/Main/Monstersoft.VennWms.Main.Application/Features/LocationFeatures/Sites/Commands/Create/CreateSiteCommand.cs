using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
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

            foreach (var siteDepositor in site.SiteDepositors)
            {
                siteDepositor.SiteId = site.Id;
                siteDepositor.Id = Guid.NewGuid();
                siteDepositor.CreatedDate = DateTime.Now;
            }

            return _mapper.Map<CreatedSiteResponse>(await _siteRepository.AddAsync(site));
        }
    }

}

