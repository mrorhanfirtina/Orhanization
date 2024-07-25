using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants.ActionParameterDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Delete;

public class DeleteActionParameterDepositorCommand : IRequest<DeletedActionParameterDepositorResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDepositors"];
    public string[] Roles => [Admin, ActionParameterDepositorOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }


    public class DeleteActionParameterDepositorCommandHandler : IRequestHandler<DeleteActionParameterDepositorCommand, DeletedActionParameterDepositorResponse>
    {
        private readonly IActionParameterDepositorRepository _actionParameterDepositorRepository;
        private readonly ActionParameterDepositorBusinessRules _actionParameterDepositorBusinessRules;

        public DeleteActionParameterDepositorCommandHandler(IActionParameterDepositorRepository actionParameterDepositorRepository, ActionParameterDepositorBusinessRules actionParameterDepositorBusinessRules)
        {
            _actionParameterDepositorRepository = actionParameterDepositorRepository;
            _actionParameterDepositorBusinessRules = actionParameterDepositorBusinessRules;
        }

        public async Task<DeletedActionParameterDepositorResponse> Handle(DeleteActionParameterDepositorCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDepositorBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterDepositor actionParameterDepositor = await _actionParameterDepositorRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _actionParameterDepositorRepository.DeleteAsync(actionParameterDepositor);

            return new DeletedActionParameterDepositorResponse
            {
                Id = actionParameterDepositor.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
            };
        }
    }
}
