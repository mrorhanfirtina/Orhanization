using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants.StorageSystemOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;

public class CreateStorageSystemCommand : IRequest<CreatedStorageSystemResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetStorageSystems";

    public CreateStorageSystemDto StorageSystem { get; set; }
    public StorageSystemsDetailLevel DetailLevel { get; set; }


    public class CreateStorageSystemCommandHandler : IRequestHandler<CreateStorageSystemCommand, CreatedStorageSystemResponse>
    {
        private readonly IStorageSystemRepository _storageSystemRepository;
        private readonly StorageSystemBusinessRules _storageSystemBusinessRules;
        private readonly IMapper _mapper;

        public CreateStorageSystemCommandHandler(IStorageSystemRepository storageSystemRepository, IMapper mapper, StorageSystemBusinessRules storageSystemBusinessRules)
        {
            _storageSystemRepository = storageSystemRepository;
            _mapper = mapper;
            _storageSystemBusinessRules = storageSystemBusinessRules;
        }

        public async Task<CreatedStorageSystemResponse> Handle(CreateStorageSystemCommand request, CancellationToken cancellationToken)
        {
            _storageSystemBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.StorageSystem.Code)
                .CheckBuildingIdExistence(request.StorageSystem.BuildingId);

            StorageSystem storageSystem = _mapper.Map<StorageSystem>(request.StorageSystem);
            storageSystem.Id = Guid.NewGuid();
            storageSystem.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            storageSystem.CreatedDate = DateTime.Now;

            await _storageSystemRepository.AddAsync(storageSystem);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _storageSystemRepository.GetAsync(predicate: x => x.Id == storageSystem.Id,
                include: x =>
                {
                    IQueryable<StorageSystem> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }

                    if (detailLevel.IncludeBuilding)
                    {
                        query = query.Include(y => y.Building);
                    }

                    if (detailLevel.IncludeLocation)
                    {
                        query = query.Include(y => y.Locations);
                    }


                    var includableQuery = query as IIncludableQueryable<StorageSystem, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStorageSystemResponse>(response);
            }
            else
            {
                var response = await _storageSystemRepository.GetAsync(predicate: x => x.Id == storageSystem.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedStorageSystemResponse>(response);
            }
        }
    }

}

