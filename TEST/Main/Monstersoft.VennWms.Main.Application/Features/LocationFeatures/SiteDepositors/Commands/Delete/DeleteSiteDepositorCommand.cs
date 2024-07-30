using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Commands.Delete;

public class DeleteSiteDepositorCommand : IRequest<DeletedSiteDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, SiteDepositorOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetSiteDepositors"];

    public Guid Id { get; set; }


    public class DeleteSiteDepositorCommandHandler : IRequestHandler<DeleteSiteDepositorCommand, DeletedSiteDepositorResponse>
    {
        private readonly ISiteDepositorRepository _siteDepositorRepository;
        private readonly SiteDepositorBusinessRules _siteDepositorBusinessRules;

        public DeleteSiteDepositorCommandHandler(ISiteDepositorRepository siteDepositorRepository, SiteDepositorBusinessRules siteDepositorBusinessRules)
        {
            _siteDepositorRepository = siteDepositorRepository;
            _siteDepositorBusinessRules = siteDepositorBusinessRules;
        }

        public async Task<DeletedSiteDepositorResponse> Handle(DeleteSiteDepositorCommand request, CancellationToken cancellationToken)
        {
            _siteDepositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            SiteDepositor siteDepositor = await _siteDepositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _siteDepositorRepository.DeleteAsync(siteDepositor);

            return new DeletedSiteDepositorResponse
            {
                Id = siteDepositor.Id,
                DepositorCompanyId = depositorCompanyId,
                DepositorId = siteDepositor.DepositorId,
                IsSuccess = true,
                Message = SiteDepositorMessages.RequestExecutedSuccessfully
            };
        }
    }
}

