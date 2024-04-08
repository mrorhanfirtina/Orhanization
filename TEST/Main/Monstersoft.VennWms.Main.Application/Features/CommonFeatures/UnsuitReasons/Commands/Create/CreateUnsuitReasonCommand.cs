using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;

public class CreateUnsuitReasonCommand : IRequest<CreatedUnsuitReasonResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUnsuitReasons";
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Add, Write];

    public CreateUnsuitReasonDto UnsuitReason { get; set; }


    public class CreateUnsuitReasonCommandHandler : IRequestHandler<CreateUnsuitReasonCommand, CreatedUnsuitReasonResponse>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public CreateUnsuitReasonCommandHandler(IUnsuitReasonRepository unsuitReasonRepository, IMapper mapper, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _mapper = mapper;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
        }

        public async Task<CreatedUnsuitReasonResponse> Handle(CreateUnsuitReasonCommand request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.UnsuitReason.Code);

            UnsuitReason unsuitReason = _mapper.Map<UnsuitReason>(request.UnsuitReason);
            unsuitReason.Id = Guid.NewGuid();
            unsuitReason.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            unsuitReason.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedUnsuitReasonResponse>(await _unsuitReasonRepository.AddAsync(unsuitReason));
        }
    }

}
