using MediatR;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Constants.LocationDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Delete;

public class DeleteLocationDepositorCommand : IRequest<DeletedLocationDepositorResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, LocationDepositorOperationClaims.Delete];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetLocationDepositors"];

    public Guid Id { get; set; }

    public class DeleteLocationDepositorCommandHandler : IRequestHandler<DeleteLocationDepositorCommand, DeletedLocationDepositorResponse>
    {
        private readonly ILocationDepositorRepository _locationDepositorRepository;
        private readonly LocationDepositorBusinessRules _locationDepositorBusinessRules;

        public DeleteLocationDepositorCommandHandler(ILocationDepositorRepository locationDepositorRepository, LocationDepositorBusinessRules locationDepositorBusinessRules)
        {
            _locationDepositorRepository = locationDepositorRepository;
            _locationDepositorBusinessRules = locationDepositorBusinessRules;
        }

        public async Task<DeletedLocationDepositorResponse> Handle(DeleteLocationDepositorCommand request, CancellationToken cancellationToken)
        {
            _locationDepositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            LocationDepositor locationDepositor = await _locationDepositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _locationDepositorRepository.DeleteAsync(locationDepositor);

            return new DeletedLocationDepositorResponse
            {
                Id = locationDepositor.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = Application.Rules.Messages.BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}

