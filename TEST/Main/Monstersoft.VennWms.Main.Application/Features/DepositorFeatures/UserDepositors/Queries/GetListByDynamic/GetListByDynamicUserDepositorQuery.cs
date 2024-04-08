using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.DepositorRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using Orhanization.Core.Security.Entities;
using static Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Constants.UserDepositorOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.UserDepositors.Queries.GetListByDynamic;

public class GetListByDynamicUserDepositorQuery : IRequest<GetListResponse<GetListByDynamicUserDepositorListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, UserDepositorOperationClaims.User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicUserDepositorQueryHandler : IRequestHandler<GetListByDynamicUserDepositorQuery, GetListResponse<GetListByDynamicUserDepositorListItemDto>>
    {
        private readonly IUserDepositorRepository _userDepositorRepository;
        private readonly UserDepositorBusinessRules _userDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicUserDepositorQueryHandler(IUserDepositorRepository userDepositorRepository, IMapper mapper, UserDepositorBusinessRules userDepositorBusinessRules)
        {
            _userDepositorRepository = userDepositorRepository;
            _userDepositorBusinessRules = userDepositorBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicUserDepositorListItemDto>> Handle(GetListByDynamicUserDepositorQuery request, CancellationToken cancellationToken)
        {
            _userDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<UserDepositor> userDepositorList = await _userDepositorRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicUserDepositorListItemDto>>(userDepositorList);
        }
    }

}
