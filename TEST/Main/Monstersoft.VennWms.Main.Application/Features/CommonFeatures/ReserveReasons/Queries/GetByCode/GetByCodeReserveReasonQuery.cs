using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Constants.ReserveReasonOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetByCode;

public class GetByCodeReserveReasonQuery : IRequest<GetByCodeReserveReasonResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string Code { get; set; }


    public class GetByCodeReserveReasonQueryHandler : IRequestHandler<GetByCodeReserveReasonQuery, GetByCodeReserveReasonResponse>
    {
        private readonly IReserveReasonRepository _reserveReasonRepository;
        private readonly ReserveReasonBusinessRules _reserveReasonBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeReserveReasonQueryHandler(IReserveReasonRepository reserveReasonRepository, IMapper mapper, ReserveReasonBusinessRules reserveReasonBusinessRules)
        {
            _reserveReasonRepository = reserveReasonRepository;
            _mapper = mapper;
            _reserveReasonBusinessRules = reserveReasonBusinessRules;
        }

        public async Task<GetByCodeReserveReasonResponse> Handle(GetByCodeReserveReasonQuery request, CancellationToken cancellationToken)
        {
            _reserveReasonBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeReserveReasonResponse>(await _reserveReasonRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
