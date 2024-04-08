using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Constants.LockReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Create;

public class CreateLockReasonCommand : IRequest<CreatedLockReasonResponse>, ITransactionalRequest, ISecuredRequest, 
    ICacheRemoveRequest, ILocalityRequest, ILoggableRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLockReasons";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, LockReasonOperationClaims.User, Add, Write];

    public CreateLockReasonDto LockReason { get; set; }


    public class CreateLockReasonCommandHandler : IRequestHandler<CreateLockReasonCommand, CreatedLockReasonResponse>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateLockReasonCommandHandler(ILockReasonRepository lockReasonRepository, IMapper mapper, LockReasonBusinessRules lockReasonBusinessRules)
        {
            _lockReasonRepository = lockReasonRepository;
            _mapper = mapper;
            _lockReasonBusinessRules = lockReasonBusinessRules;
        }

        public async Task<CreatedLockReasonResponse> Handle(CreateLockReasonCommand request, CancellationToken cancellationToken)
        {
            _lockReasonBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.LockReason.Code);

            LockReason lockReason = _mapper.Map<LockReason>(request.LockReason);
            lockReason.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            lockReason.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedLockReasonResponse>(await _lockReasonRepository.AddAsync(lockReason));
        }
    }
}
