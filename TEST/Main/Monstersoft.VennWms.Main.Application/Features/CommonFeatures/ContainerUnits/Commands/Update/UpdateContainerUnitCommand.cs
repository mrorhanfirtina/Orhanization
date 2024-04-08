using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants.ContainerUnitOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;

public class UpdateContainerUnitCommand : IRequest<UpdatedContainerUnitResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string[] Roles => [Admin, User, Write, ContainerUnitOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateContainerUnitDto ContainerUnit { get; set; }


    public class UpdateContainerUnitCommandHandler : IRequestHandler<UpdateContainerUnitCommand, UpdatedContainerUnitResponse>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public UpdateContainerUnitCommandHandler(IContainerUnitRepository containerUnitRepository, ContainerUnitBusinessRules containerUnitBusinessRules, IMapper mapper)
        {
            _containerUnitRepository = containerUnitRepository;
            _containerUnitBusinessRules = containerUnitBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedContainerUnitResponse> Handle(UpdateContainerUnitCommand request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ContainerUnit.Id)
            .CheckCodeExistenceWhenUpdate(request.ContainerUnit.Code, request.ContainerUnit.Id);

            ContainerUnit? currentContainerUnit = await _containerUnitRepository.GetAsync(predicate: x => x.Id == request.ContainerUnit.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ContainerUnit? containerUnit = _mapper.Map(request.ContainerUnit, currentContainerUnit);
            containerUnit.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedContainerUnitResponse>(await _containerUnitRepository.UpdateAsync(containerUnit));
        }
    }

}
