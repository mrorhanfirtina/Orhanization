using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Commands.Update;

public class UpdateActionParameterCategoryCommand : IRequest<UpdatedActionParameterCategoryResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterCategories"];
    public string[] Roles => [Admin, ActionParameterCategoryOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateActionParameterCategoryDto ActionParameterCategory { get; set; }
    public ActionParameterCategoryDetailLevel DetailLevel { get; set; }


    public class UpdateActionParameterCategoryCommandHandler : IRequestHandler<UpdateActionParameterCategoryCommand, UpdatedActionParameterCategoryResponse>
    {
        private readonly IActionParameterCategoryRepository _actionParameterCategoryRepository;
        private readonly ActionParameterCategoryBusinessRules _actionParameterCategoryBusinessRules;
        private readonly IMapper _mapper;

        public UpdateActionParameterCategoryCommandHandler(IActionParameterCategoryRepository actionParameterCategoryRepository, ActionParameterCategoryBusinessRules actionParameterCategoryBusinessRules, IMapper mapper)
        {
            _actionParameterCategoryRepository = actionParameterCategoryRepository;
            _actionParameterCategoryBusinessRules = actionParameterCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedActionParameterCategoryResponse> Handle(UpdateActionParameterCategoryCommand request, CancellationToken cancellationToken)
        {
            _actionParameterCategoryBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ActionParameterCategory.Id);

            ActionParameterCategory? currentActionParameterCategory = await _actionParameterCategoryRepository.GetAsync(
            predicate: x => x.Id == request.ActionParameterCategory.Id,
            cancellationToken: cancellationToken,
            withDeleted: false,enableTracking: true);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ActionParameterCategory? actionParameterCategory = _mapper.Map(request.ActionParameterCategory, currentActionParameterCategory);
            actionParameterCategory.UpdatedDate = DateTime.Now;


            await _actionParameterCategoryRepository.UpdateAsync(actionParameterCategory);


            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterCategoryRepository.GetAsync(predicate: x => x.Id == actionParameterCategory.Id,
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

                return _mapper.Map<UpdatedActionParameterCategoryResponse>(response);
            }
            else
            {
                var response = await _actionParameterCategoryRepository.GetAsync(predicate: x => x.Id == actionParameterCategory.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterCategoryResponse>(response);

            }
        }
    }
}
