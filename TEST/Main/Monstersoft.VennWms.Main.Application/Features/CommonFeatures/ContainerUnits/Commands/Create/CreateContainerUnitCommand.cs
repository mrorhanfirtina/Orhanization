using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;

public class CreateContainerUnitCommand : IRequest<CreatedContainerUnitResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public CreateContainerUnitDto? ContainerUnit { get; set; }


    public class CreateContainerUnitCommandHandler : IRequestHandler<CreateContainerUnitCommand, CreatedContainerUnitResponse>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public CreateContainerUnitCommandHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, ContainerUnitBusinessRules containerUnitBusinessRules)
        {
            _containerUnitRepository = containerUnitRepository;
            _mapper = mapper;
            _containerUnitBusinessRules = containerUnitBusinessRules;
        }

        public async Task<CreatedContainerUnitResponse> Handle(CreateContainerUnitCommand request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ContainerUnit.Code);

            ContainerUnit containerUnit = _mapper.Map<ContainerUnit>(request.ContainerUnit);
            containerUnit.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            containerUnit.CreatedDate = DateTime.Now;

            return _mapper.Map<CreatedContainerUnitResponse>(await _containerUnitRepository.AddAsync(containerUnit));
        }
    }

}


