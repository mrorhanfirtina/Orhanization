using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
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

            return _mapper.Map<CreatedSiteDepositorResponse>(await _siteDepositorRepository.AddAsync(siteDepositor));
        }
    }

}

