using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Constants.UnsuitReasonOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;

public class GetByCodeUnsuitReasonQuery : IRequest<GetByCodeUnsuitReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string Code { get; set; }


    public class GetByCodeUnsuitReasonQueryHandler : IRequestHandler<GetByCodeUnsuitReasonQuery, GetByCodeUnsuitReasonResponse>
    {
        private readonly IUnsuitReasonRepository _unsuitReasonRepository;
        private readonly UnsuitReasonBusinessRules _unsuitReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeUnsuitReasonQueryHandler(IUnsuitReasonRepository unsuitReasonRepository, IMapper mapper, UnsuitReasonBusinessRules unsuitReasonBusinessRules)
        {
            _unsuitReasonRepository = unsuitReasonRepository;
            _mapper = mapper;
            _unsuitReasonBusinessRules = unsuitReasonBusinessRules;
        }

        public async Task<GetByCodeUnsuitReasonResponse> Handle(GetByCodeUnsuitReasonQuery request, CancellationToken cancellationToken)
        {
            _unsuitReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeUnsuitReasonResponse>(await _unsuitReasonRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }
}
