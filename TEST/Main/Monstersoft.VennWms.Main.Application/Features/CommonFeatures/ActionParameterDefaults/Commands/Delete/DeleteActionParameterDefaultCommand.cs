using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Rules.Messages;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants.ActionParameterDefaultOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class DeleteActionParameterDefaultCommand : IRequest<DeletedActionParameterDefaultResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, ActionParameterDefaultOperationClaims.Delete, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDefaults"];

    public Guid Id { get; set; }


    public class DeleteActionParameterDefaultCommandHandler : IRequestHandler<DeleteActionParameterDefaultCommand, DeletedActionParameterDefaultResponse>
    {
        private readonly IActionParameterDefaultRepository _actionParameterDefaultRepository;
        private readonly ActionParameterDefaultBusinessRules _actionParameterDefaultBusinessRules;

        public DeleteActionParameterDefaultCommandHandler(IActionParameterDefaultRepository actionParameterDefaultRepository, ActionParameterDefaultBusinessRules actionParameterDefaultBusinessRules)
        {
            _actionParameterDefaultRepository = actionParameterDefaultRepository;
            _actionParameterDefaultBusinessRules = actionParameterDefaultBusinessRules;
        }

        public async Task<DeletedActionParameterDefaultResponse> Handle(DeleteActionParameterDefaultCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDefaultBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterDefault actionParameterDefault = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: false,
            cancellationToken: cancellationToken);

            await _actionParameterDefaultRepository.DeleteAsync(actionParameterDefault);

            return new DeletedActionParameterDefaultResponse
            {
                Id = actionParameterDefault.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
                Message = BaseMessages.RequestExecutedSuccessfully
            };
        }
    }
}
