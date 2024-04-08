using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Update;

public class UpdateStorageSystemCommand : IRequest<UpdatedStorageSystemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, StorageSystemOperationClaims.Update, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStorageSystems";

    public UpdateStorageSystemDto StorageSystem { get; set; }


    public class UpdateStorageSystemCommandHandler : IRequestHandler<UpdateStorageSystemCommand, UpdatedStorageSystemResponse>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public UpdateStorageSystemCommandHandler(IStorageSystemRepository storageSystemRepository, StorageSystemBusinessRules storageSystemBusinessRules, IMapper mapper)
        {
            _storageSystemRepository = storageSystemRepository;
            _storageSystemBusinessRules = storageSystemBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedStorageSystemResponse> Handle(UpdateStorageSystemCommand request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.StorageSystem.Id)
            .CheckCodeExistenceWhenUpdate(request.StorageSystem.Code, request.StorageSystem.Id)
            .CheckBuildingIdExistence(request.StorageSystem.BuildingId);

            StorageSystem? currentStorageSystem = await _storageSystemRepository.GetAsync(predicate: x => x.Id == request.StorageSystem.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            StorageSystem? storageSystem = _mapper.Map(request.StorageSystem, currentStorageSystem);
            storageSystem.UpdatedDate = DateTime.Now;

            //Db'ye ekleme yapılıyor.
            return _mapper.Map<UpdatedStorageSystemResponse>(await _storageSystemRepository.UpdateAsync(storageSystem));
        }
    }
}

