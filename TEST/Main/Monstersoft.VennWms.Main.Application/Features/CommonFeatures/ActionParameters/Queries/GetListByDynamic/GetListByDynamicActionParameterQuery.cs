using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants.ActionParameterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByDynamic;

public class GetListByDynamicActionParameterQuery : IRequest<GetListResponse<GetListByDynamicActionParameterListItemDto>>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ActionParameterDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicActionParameterQueryHandler : IRequestHandler<GetListByDynamicActionParameterQuery, GetListResponse<GetListByDynamicActionParameterListItemDto>>
    {
        private readonly IActionParameterRepository _actionParameterRepository;
        private readonly ActionParameterBusinessRules _actionParameterBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicActionParameterQueryHandler(IActionParameterRepository actionParameterRepository, IMapper mapper, ActionParameterBusinessRules actionParameterBusinessRules)
        {
            _actionParameterRepository = actionParameterRepository;
            _actionParameterBusinessRules = actionParameterBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicActionParameterListItemDto>> Handle(GetListByDynamicActionParameterQuery request, CancellationToken cancellationToken)
        {
            _actionParameterBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                Paginate<ActionParameter> actionParameter = await _actionParameterRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ActionParameter> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameterUser)
                    {
                        query = query.Include(y => y.ActionParameterUsers);

                        if (detailLevel.ActionParameterUserDetailLevel.IncludeUser)
                        {
                            query = query.Include(y => y.ActionParameterUsers).ThenInclude(v => v.User);
                        }
                    }

                    if (detailLevel.IncludeActionParameterCategory)
                    {
                        query = query.Include(y => y.ActionParameterCategory);
                    }

                    if (detailLevel.IncludeActionParameterDepositor)
                    {
                        query = query.Include(y => y.ActionParameterDepositors);

                        if (detailLevel.ActionParameterDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor);

                            if (detailLevel.ActionParameterDepositorDetailLevel.ActionParameterCompanyDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor).ThenInclude(v => v.Company);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameter, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterListItemDto>>(actionParameter);
            }
            else
            {
                Paginate<ActionParameter> actionParameter = await _actionParameterRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterListItemDto>>(actionParameter);
            }
        }
    }
}
