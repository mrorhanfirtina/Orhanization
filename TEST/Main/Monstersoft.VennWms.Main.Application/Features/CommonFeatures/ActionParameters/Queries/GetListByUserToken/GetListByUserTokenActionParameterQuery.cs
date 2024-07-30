using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;
using Monstersoft.VennWms.Main.Application.Services.Abstract.CommonServices;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants.ActionParameterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetListByUserToken;

public class GetListByUserTokenActionParameterQuery : IRequest<List<GetListByUserTokenActionParameterListItemDto>>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest, ICachableRequest
{
    public string[] Roles => [Admin, ActionParameterOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid? DepositorId { get; set; } = null;
    public string CacheKey => $"GetListByUserTokenActionParameterQuery($USER)";
    public bool ByPassCache { get; }
    public string? CacheGroupKey => "GetActionParameters";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListByUserTokenActionParameterQueryHandler : IRequestHandler<GetListByUserTokenActionParameterQuery, List<GetListByUserTokenActionParameterListItemDto>>
    {
        private readonly IActionParameterService _actionParameterManager;
        private readonly ActionParameterBusinessRules _actionParameterBusinessRules;
        private readonly IMapper _mapper;

        public GetListByUserTokenActionParameterQueryHandler(IActionParameterService actionParameterManager, ActionParameterBusinessRules actionParameterBusinessRules, IMapper mapper)
        {
            _actionParameterManager = actionParameterManager;
            _actionParameterBusinessRules = actionParameterBusinessRules;
            _mapper = mapper;
        }

        public async Task<List<GetListByUserTokenActionParameterListItemDto>> Handle(GetListByUserTokenActionParameterQuery request, CancellationToken cancellationToken)
        {
            _actionParameterBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckDepositorId(request.UserRequestInfo.RequestUserId, request.DepositorId);

            int userId = request.UserRequestInfo.RequestUserId;
            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            var parameters = _actionParameterManager.GetUserActionParameters(userId, depositorCompanyId, request.DepositorId);

            return await Task.FromResult(_mapper.Map<List<GetListByUserTokenActionParameterListItemDto>>(parameters));
        }
    }
}
