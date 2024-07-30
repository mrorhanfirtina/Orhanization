using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Rules;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants.ActionParameterCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetListByDynamic;

public class GetListByDynamicActionParameterCategoryQuery : IRequest<GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterCategoryOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ActionParameterCategoryDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicActionParameterCategoryQueryHandler : IRequestHandler<GetListByDynamicActionParameterCategoryQuery, GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>>
    {
        private readonly IActionParameterCategoryRepository _actionParameterCategoryRepository;
        private readonly ActionParameterCategoryBusinessRules _actionParameterCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicActionParameterCategoryQueryHandler(IActionParameterCategoryRepository actionParameterCategoryRepository, IMapper mapper, ActionParameterCategoryBusinessRules actionParameterCategoryBusinessRules)
        {
            _actionParameterCategoryRepository = actionParameterCategoryRepository;
            _actionParameterCategoryBusinessRules = actionParameterCategoryBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>> Handle(GetListByDynamicActionParameterCategoryQuery request, CancellationToken cancellationToken)
        {
            _actionParameterCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ActionParameterCategory> actionParameterCategory = await _actionParameterCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
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
                },
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>>(actionParameterCategory);
            }
            else
            {
                Paginate<ActionParameterCategory> actionParameterCategory = await _actionParameterCategoryRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterCategoryListItemDto>>(actionParameterCategory);
            }
        }
    }
}
