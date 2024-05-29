using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Dtos.DtoProfiles;

public class BuildingDtoMappingProfiles : Profile
{
    public BuildingDtoMappingProfiles()
    {
        CreateMap<Building, CreateBuildingDto>().ReverseMap();
        CreateMap<Building, UpdateBuildingDto>().ReverseMap();

        CreateMap<BuildingDimension, BuildingBuildingDimensionResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BuildingDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, BuildingDepositorResponseDto>().ReverseMap();
        CreateMap<Unit, BuildingLenghtUnitResponseDto>().ReverseMap();
        CreateMap<SiteDepositor, BuildingSiteDepositorResponseDto>().ReverseMap();
        CreateMap<Site, BuildingSiteResponseDto>().ReverseMap();
        CreateMap<StorageSystem, BuildingStorageSystemResponseDto>().ReverseMap();
        CreateMap<Unit, BuildingVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Zone, BuildingZoneResponseDto>().ReverseMap();
    }
}
