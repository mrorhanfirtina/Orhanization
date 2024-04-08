using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;

public class UpdateUnitCommand : IRequest<UpdatedUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetUnits";
    public string[] Roles => [Admin, User, Write, UnitOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateUnitDto Unit { get; set; }


    public class UpdateUnitCommandHandler : IRequestHandler<UpdateUnitCommand, UpdatedUnitResponse>
    {
        private readonly IUnitRepository _unitRepository;
        private readonly UnitBusinessRules _unitBusinessRules;
        private readonly IMapper _mapper;

        public UpdateUnitCommandHandler(IUnitRepository unitRepository, UnitBusinessRules unitBusinessRules, IMapper mapper)
        {
            _unitRepository = unitRepository;
            _unitBusinessRules = unitBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedUnitResponse> Handle(UpdateUnitCommand request, CancellationToken cancellationToken)
        {
            _unitBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Unit.Id)
            .CheckCodeExistenceWhenUpdate(request.Unit.Code, request.Unit.Id);

            Unit? currentUnit = await _unitRepository.GetAsync(predicate: x => x.Id == request.Unit.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            Unit? unit = _mapper.Map(request.Unit, currentUnit);
            unit.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedUnitResponse>(await _unitRepository.UpdateAsync(unit));
        }
    }
}
