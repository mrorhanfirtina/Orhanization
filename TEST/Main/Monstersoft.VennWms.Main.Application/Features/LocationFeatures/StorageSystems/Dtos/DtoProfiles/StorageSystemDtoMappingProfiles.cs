using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.DtoProfiles;

public class StorageSystemDtoMappingProfiles : Profile
{
    public StorageSystemDtoMappingProfiles()
    {
        CreateMap<StorageSystem, CreateStorageSystemDto>().ReverseMap();
        CreateMap<StorageSystem, UpdateStorageSystemDto>().ReverseMap();

        CreateMap<Building, StorageSystemBuildingResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, StorageSystemDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Location, StorageSystemLocationResponseDto>().ReverseMap();
    }
}
