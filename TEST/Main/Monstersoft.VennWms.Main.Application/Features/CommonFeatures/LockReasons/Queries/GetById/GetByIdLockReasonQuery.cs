using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants.LockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetById;

public class GetByIdLockReasonQuery : IRequest<GetByIdLockReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }


    public class GetByIdLockReasonQueryHandler : IRequestHandler<GetByIdLockReasonQuery, GetByIdLockReasonResponse>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdLockReasonQueryHandler(ILockReasonRepository lockReasonRepository, IMapper mapper, LockReasonBusinessRules lockReasonBusinessRules)
        {
            _lockReasonRepository = lockReasonRepository;
            _mapper = mapper;
            _lockReasonBusinessRules = lockReasonBusinessRules;
        }

        public async Task<GetByIdLockReasonResponse> Handle(GetByIdLockReasonQuery request, CancellationToken cancellationToken)
        {
            _lockReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdLockReasonResponse>(await _lockReasonRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, 
                cancellationToken: cancellationToken));
        }
    }
}

