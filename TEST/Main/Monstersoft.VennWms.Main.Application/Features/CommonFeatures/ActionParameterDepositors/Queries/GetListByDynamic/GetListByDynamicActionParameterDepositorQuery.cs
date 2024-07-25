using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants.ActionParameterDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetListByDynamic;

public class GetListByDynamicActionParameterDepositorQuery : IRequest<GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterDepositorOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ActionParameterDepositorDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicActionParameterDepositorQueryHandler : IRequestHandler<GetListByDynamicActionParameterDepositorQuery, GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>>
    {
        private readonly IActionParameterDepositorRepository _actionParameterDepositorRepository;
        private readonly ActionParameterDepositorBusinessRules _actionParameterDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicActionParameterDepositorQueryHandler(IActionParameterDepositorRepository actionParameterDepositorRepository, IMapper mapper, ActionParameterDepositorBusinessRules actionParameterDepositorBusinessRules)
        {
            _actionParameterDepositorRepository = actionParameterDepositorRepository;
            _actionParameterDepositorBusinessRules = actionParameterDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>> Handle(GetListByDynamicActionParameterDepositorQuery request, CancellationToken cancellationToken)
        {
            _actionParameterDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ActionParameterDepositor> actionParameterDepositor = await _actionParameterDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ActionParameterDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);

                        if (detailLevel.ActionParameterDepositorParameterDetailLevel.IncludeCategory)
                        {
                            query = query.Include(y => y.ActionParameter).ThenInclude(v => v.ActionParameterCategory);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        if (detailLevel.ActionParameterDepositorDepositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(v => v.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterDepositor, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>>(actionParameterDepositor);
            }
            else
            {
                Paginate<ActionParameterDepositor> actionParameterDepositor = await _actionParameterDepositorRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterDepositorListItemDto>>(actionParameterDepositor);
            }
        }
    }
}
