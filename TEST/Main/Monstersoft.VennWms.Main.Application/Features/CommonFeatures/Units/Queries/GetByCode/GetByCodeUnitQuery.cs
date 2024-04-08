using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetByCode;

public class GetByCodeUnitQuery : IRequest<GetByCodeUnitResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [ Admin, User, Read ];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public string Code { get; set; }


    public class GetByCodeUnitQueryHandler : IRequestHandler<GetByCodeUnitQuery, GetByCodeUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeUnitQueryHandler(IUnitRepository unitRepository, IMapper mapper, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _unitBusinessRules = unitBusinessRules;
        }

        public async Task<GetByCodeUnitResponse> Handle(GetByCodeUnitQuery request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeUnitResponse>(await _unitRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
