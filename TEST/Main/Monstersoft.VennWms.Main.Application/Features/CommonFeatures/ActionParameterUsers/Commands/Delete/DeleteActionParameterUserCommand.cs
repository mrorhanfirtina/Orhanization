using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants.ActionParameterUserOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Delete;

public class DeleteActionParameterUserCommand : IRequest<DeletedActionParameterUserResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterUsers"];
    public string[] Roles => [Admin, ActionParameterUserOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }


    public class DeleteActionParameterUserCommandHandler : IRequestHandler<DeleteActionParameterUserCommand, DeletedActionParameterUserResponse>
    {
        private readonly IActionParameterUserRepository _actionParameterUserRepository;
        private readonly ActionParameterUserBusinessRules _actionParameterUserBusinessRules;

        public DeleteActionParameterUserCommandHandler(IActionParameterUserRepository actionParameterUserRepository, ActionParameterUserBusinessRules actionParameterUserBusinessRules)
        {
            _actionParameterUserRepository = actionParameterUserRepository;
            _actionParameterUserBusinessRules = actionParameterUserBusinessRules;
        }

        public async Task<DeletedActionParameterUserResponse> Handle(DeleteActionParameterUserCommand request, CancellationToken cancellationToken)
        {
            _actionParameterUserBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterUser actionParameterUser = await _actionParameterUserRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false, enableTracking: false, cancellationToken: cancellationToken);

            await _actionParameterUserRepository.DeleteAsync(actionParameterUser);

            return new DeletedActionParameterUserResponse
            {
                Id = actionParameterUser.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
            };
        }
    }
}
