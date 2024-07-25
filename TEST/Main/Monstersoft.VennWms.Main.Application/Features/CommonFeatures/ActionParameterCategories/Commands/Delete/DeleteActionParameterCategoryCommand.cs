using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants.ActionParameterCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Delete;

public class DeleteActionParameterCategoryCommand : IRequest<DeletedActionParameterCategoryResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterCategories"];
    public string[] Roles => [Admin, ActionParameterCategoryOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }


    public class DeleteActionParameterCategoryCommandHandler : IRequestHandler<DeleteActionParameterCategoryCommand, DeletedActionParameterCategoryResponse>
    {
        private readonly IActionParameterCategoryRepository _actionParameterCategoryRepository;
        private readonly ActionParameterCategoryBusinessRules _actionParameterCategoryBusinessRules;

        public DeleteActionParameterCategoryCommandHandler(IActionParameterCategoryRepository actionParameterCategoryRepository, ActionParameterCategoryBusinessRules actionParameterCategoryBusinessRules)
        {
            _actionParameterCategoryRepository = actionParameterCategoryRepository;
            _actionParameterCategoryBusinessRules = actionParameterCategoryBusinessRules;
        }

        public async Task<DeletedActionParameterCategoryResponse> Handle(DeleteActionParameterCategoryCommand request, CancellationToken cancellationToken)
        {
            _actionParameterCategoryBusinessRules.DeleteRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterCategory actionParameterCategory = await _actionParameterCategoryRepository.GetAsync(predicate: x => x.Id == request.Id,
            withDeleted: false,
            enableTracking: true,
            cancellationToken: cancellationToken);

            await _actionParameterCategoryRepository.DeleteAsync(actionParameterCategory);

            return new DeletedActionParameterCategoryResponse
            {
                Id = actionParameterCategory.Id,
                DepositorCompanyId = depositorCompanyId,
                IsSuccess = true,
            };
        }
    }
}
