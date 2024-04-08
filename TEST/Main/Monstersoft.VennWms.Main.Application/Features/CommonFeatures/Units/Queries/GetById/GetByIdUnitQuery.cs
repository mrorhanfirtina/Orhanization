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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;

public class GetByIdUnitQuery : IRequest<GetByIdUnitResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }


    public class GetByIdUnitQueryHandler : IRequestHandler<GetByIdUnitQuery, GetByIdUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdUnitQueryHandler(IUnitRepository unitRepository, IMapper mapper, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _unitBusinessRules = unitBusinessRules;
        }

        public async Task<GetByIdUnitResponse> Handle(GetByIdUnitQuery request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdUnitResponse>(await _unitRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}
