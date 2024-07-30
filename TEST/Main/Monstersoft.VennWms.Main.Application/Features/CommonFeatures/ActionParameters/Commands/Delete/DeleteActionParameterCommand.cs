using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants.ActionParameterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Commands.Delete;

public class DeleteActionParameterCommand : IRequest<DeletedActionParameterResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameters"];
    public string[] Roles => [Admin, ActionParameterOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }


    public class DeleteActionParameterCommandHandler : IRequestHandler<DeleteActionParameterCommand, DeletedActionParameterResponse>
    {
        private readonly IActionParameterRepository _actionParameterRepository;
        private readonly ActionParameterBusinessRules _actionParameterBusinessRules;

        public DeleteActionParameterCommandHandler(IActionParameterRepository actionParameterRepository, ActionParameterBusinessRules actionParameterBusinessRules)
        {
            _actionParameterRepository = actionParameterRepository;
            _actionParameterBusinessRules = actionParameterBusinessRules;
        }

        public async Task<DeletedActionParameterResponse> Handle(DeleteActionParameterCommand request, CancellationToken cancellationToken)
        {
            _actionParameterBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameter actionParameter = await _actionParameterRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _actionParameterRepository.DeleteAsync(actionParameter);

            return new DeletedActionParameterResponse
            {
                Id = actionParameter.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
            };
        }
    }
}
