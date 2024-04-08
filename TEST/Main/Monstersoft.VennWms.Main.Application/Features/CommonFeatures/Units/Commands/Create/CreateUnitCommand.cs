using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants.UnitOperationClaims;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Create;

public class CreateUnitCommand : IRequest<CreatedUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUnits";
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public CreateUnitDto Unit { get; set; }


    public class CreateUnitCommandHandler : IRequestHandler<CreateUnitCommand, CreatedUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public CreateUnitCommandHandler(IUnitRepository unitRepository, IMapper mapper, UnitBusinessRules unitBusinessRules)
        {
            _unitRepository = unitRepository;
            _mapper = mapper;
            _unitBusinessRules = unitBusinessRules;
        }

        public async Task<CreatedUnitResponse> Handle(CreateUnitCommand request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.Unit.Code);

            Unit unit = _mapper.Map<Unit>(request.Unit);
            unit.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            unit.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedUnitResponse>(await _unitRepository.AddAsync(unit));
        }
    }

}
