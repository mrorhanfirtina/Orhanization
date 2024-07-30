using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Rules;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants.ActionParameterDefaultOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class GetListByDynamicActionParameterDefaultQuery : IRequest<GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }
    public ActionParameterDefaultsDetailLevel DetailLevel { get; set; }


    public class GetListByDynamicActionParameterDefaultQueryHandler : IRequestHandler<GetListByDynamicActionParameterDefaultQuery, GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>>
    {
        private readonly IActionParameterDefaultRepository _actionParameterDefaultRepository;
        private readonly ActionParameterDefaultBusinessRules _actionParameterDefaultBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicActionParameterDefaultQueryHandler(IActionParameterDefaultRepository actionParameterDefaultRepository, IMapper mapper, ActionParameterDefaultBusinessRules actionParameterDefaultBusinessRules)
        {
            _actionParameterDefaultRepository = actionParameterDefaultRepository;
            _actionParameterDefaultBusinessRules = actionParameterDefaultBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>> Handle(GetListByDynamicActionParameterDefaultQuery request, CancellationToken cancellationToken)
        {
            _actionParameterDefaultBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                Paginate<ActionParameterDefault> actionParameterDefaultList = await _actionParameterDefaultRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                include: x =>
                {
                    IQueryable<ActionParameterDefault> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(x => x.ActionParameter);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<ActionParameterDefault, object>;
                    return includableQuery;
                },
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>>(actionParameterDefaultList);
            }
            else
            {
                Paginate<ActionParameterDefault> actionParameterDefaultList = await _actionParameterDefaultRepository.GetListByDynamicAsync(
                dynamic: request.DynamicQuery,
                index: request.PageRequest.PageIndex, enableTracking: false,
                size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

                return _mapper.Map<GetListResponse<GetListByDynamicActionParameterDefaultListItemDto>>(actionParameterDefaultList);
            }
        }
    }
}
