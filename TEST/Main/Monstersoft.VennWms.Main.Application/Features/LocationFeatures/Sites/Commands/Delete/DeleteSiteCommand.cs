using MediatR;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Constants;
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


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Sites.Commands.Delete;

public class DeleteSiteCommand : IRequest<DeletedSiteResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, SiteOperationClaims.Delete, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetSites";

    public Guid Id { get; set; }


    public class DeleteSiteCommandHandler : IRequestHandler<DeleteSiteCommand, DeletedSiteResponse>
    {
        private readonly ISiteRepository _siteRepository;
        private readonly SiteBusinessRules _siteBusinessRules;

        public DeleteSiteCommandHandler(ISiteRepository siteRepository, SiteBusinessRules siteBusinessRules)
        {
            _siteRepository = siteRepository;
            _siteBusinessRules = siteBusinessRules;
        }

        public async Task<DeletedSiteResponse> Handle(DeleteSiteCommand request, CancellationToken cancellationToken)
        {
            _siteBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Site? site = await _siteRepository.GetAsync(predicate: x => x.Id == request.Id,
            include: x => x.Include(y => y.SiteDepositors),
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _siteRepository.DeleteAsync(site);

            return new DeletedSiteResponse
            {
                Id = site.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = SiteMessages.RequestExecutedSuccessfully
            };
        }
    }

}

