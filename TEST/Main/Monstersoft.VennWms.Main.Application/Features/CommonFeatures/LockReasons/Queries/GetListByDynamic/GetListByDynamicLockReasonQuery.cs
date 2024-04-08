using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
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
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants.LockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetListByDynamic;

public class GetListByDynamicLockReasonQuery : IRequest<GetListResponse<GetListByDynamicLockReasonListItemDto>>, ITransactionalRequest, ILoggableRequest, 
    ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicLockReasonQueryHandler : IRequestHandler<GetListByDynamicLockReasonQuery, GetListResponse<GetListByDynamicLockReasonListItemDto>>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicLockReasonQueryHandler(ILockReasonRepository lockReasonRepository, IMapper mapper, LockReasonBusinessRules lockReasonBusinessRules)
        {
            _lockReasonRepository = lockReasonRepository;
            _lockReasonBusinessRules = lockReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicLockReasonListItemDto>> Handle(GetListByDynamicLockReasonQuery request, CancellationToken cancellationToken)
        {
            _lockReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<LockReason> lockReasonList = await _lockReasonRepository.GetListByDynamicAsync(
                           dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
                                      index: request.PageRequest.PageIndex,
                                                 size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicLockReasonListItemDto>>(lockReasonList);
        }
    }
}
