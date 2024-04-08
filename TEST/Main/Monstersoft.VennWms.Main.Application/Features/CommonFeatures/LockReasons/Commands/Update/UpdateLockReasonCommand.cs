using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;

public class UpdateLockReasonCommand : IRequest<UpdatedLockReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, 
    ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetLockReasons";
    public string[] Roles => [ Admin, User, Write, LockReasonOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateLockReasonDto LockReason { get; set; }


    public class UpdateLockReasonCommandHandler : IRequestHandler<UpdateLockReasonCommand, UpdatedLockReasonResponse>
    {
        private readonly ILockReasonRepository _lockReasonRepository;
        private readonly LockReasonBusinessRules _lockReasonBusinessRules;
        private readonly IMapper _mapper;

        public UpdateLockReasonCommandHandler(ILockReasonRepository lockReasonRepository, LockReasonBusinessRules lockReasonBusinessRules, IMapper mapper)
        {
            _lockReasonRepository = lockReasonRepository;
            _lockReasonBusinessRules = lockReasonBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedLockReasonResponse> Handle(UpdateLockReasonCommand request, CancellationToken cancellationToken)
        {
            _lockReasonBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.LockReason.Id)
            .CheckCodeExistenceWhenUpdate(request.LockReason.Code, request.LockReason.Id);

            LockReason? currentLockReason = await _lockReasonRepository.GetAsync(predicate: x => x.Id == request.LockReason.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            LockReason? lockReason = _mapper.Map(request.LockReason, currentLockReason);
            lockReason.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedLockReasonResponse>(await _lockReasonRepository.UpdateAsync(lockReason));
        }
    }
}

