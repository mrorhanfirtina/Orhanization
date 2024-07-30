using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants.ActionParameterUserOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Queries.GetListByDynamic;

public class GetListByDynamicActionParameterUserQuery : IRequest<GetListResponse<GetListByDynamicActionParameterUserListItemDto>>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterUserOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ActionParameterUserDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicActionParameterUserQueryHandler : IRequestHandler<GetListByDynamicActionParameterUserQuery, GetListResponse<GetListByDynamicActionParameterUserListItemDto>>
    {
        private readonly IActionParameterUserRepository _actionParameterUserRepository;
        private readonly ActionParameterUserBusinessRules _actionParameterUserBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicActionParameterUserQueryHandler(IActionParameterUserRepository actionParameterUserRepository, IMapper mapper, ActionParameterUserBusinessRules actionParameterUserBusinessRules)
        {
            _actionParameterUserRepository = actionParameterUserRepository;
            _actionParameterUserBusinessRules = actionParameterUserBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicActionParameterUserListItemDto>> Handle(GetListByDynamicActionParameterUserQuery request, CancellationToken cancellationToken)
        {
            _actionParameterUserBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ActionParameterUser> actionParameterUser = await _actionParameterUserRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ActionParameterUser> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);
                    }

                    if (detailLevel.IncludeUser)
                    {
                        query = query.Include(y => y.User);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterUser, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterUserListItemDto>>(actionParameterUser);
            }
            else
            {
                Paginate<ActionParameterUser> actionParameterUser = await _actionParameterUserRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterUserListItemDto>>(actionParameterUser);
            }
        }
    }
}
