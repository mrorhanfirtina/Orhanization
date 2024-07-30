using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants.ActionParameterCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Create;

public class CreateActionParameterCategoryCommand : IRequest<CreatedActionParameterCategoryResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterCategories"];
    public string[] Roles => [Admin, ActionParameterCategoryOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public CreateActionParameterCategoryDto ActionParameterCategory { get; set; }
    public ActionParameterCategoryDetailLevel DetailLevel { get; set; }


    public class CreateActionParameterCategoryCommandHandler : IRequestHandler<CreateActionParameterCategoryCommand, CreatedActionParameterCategoryResponse>
    {
        private readonly IActionParameterCategoryRepository _actionParameterCategoryRepository;
        private readonly ActionParameterCategoryBusinessRules _actionParameterCategoryBusinessRules;
        private readonly IMapper _mapper;

        public CreateActionParameterCategoryCommandHandler(IActionParameterCategoryRepository actionParameterCategoryRepository, IMapper mapper, ActionParameterCategoryBusinessRules actionParameterCategoryBusinessRules)
        {
            _actionParameterCategoryRepository = actionParameterCategoryRepository;
            _mapper = mapper;
            _actionParameterCategoryBusinessRules = actionParameterCategoryBusinessRules;
        }

        public async Task<CreatedActionParameterCategoryResponse> Handle(CreateActionParameterCategoryCommand request, CancellationToken cancellationToken)
        {
            _actionParameterCategoryBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterCategory actionParameterCategory = _mapper.Map<ActionParameterCategory>(request.ActionParameterCategory);
            actionParameterCategory.CreatedDate = DateTime.Now;

            ActionParameterCategory createdRecord = await _actionParameterCategoryRepository.AddAsync(actionParameterCategory);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterCategoryRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<ActionParameterCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameters);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterCategory, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterCategoryResponse>(response);
            }
            else
            {
                var response = await _actionParameterCategoryRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterCategoryResponse>(response);

            }
        }
    }
}
