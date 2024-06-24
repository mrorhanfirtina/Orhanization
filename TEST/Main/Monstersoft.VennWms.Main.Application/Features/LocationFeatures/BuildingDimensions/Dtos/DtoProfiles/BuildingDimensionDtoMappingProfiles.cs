using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BuildingDimensions.Dtos.DtoProfiles;

public class BuildingDimensionDtoMappingProfiles : Profile
{
    public BuildingDimensionDtoMappingProfiles()
    {
        CreateMap<BuildingDimension, CreateBuildingDimensionDto>().ReverseMap();
        CreateMap<BuildingDimension, CreateBuildingDimensionSubDto>().ReverseMap();
        CreateMap<BuildingDimension, UpdateBuildingDimensionDto>().ReverseMap();
        CreateMap<BuildingDimension, UpdateBuildingDimensionSubDto>().ReverseMap();

        CreateMap<Building, BuildingDimensionBuildingResponseDto>().ReverseMap();
        CreateMap<Unit, BuildingDimensionLenghtUnitResponseDto>().ReverseMap();
        CreateMap<Unit, BuildingDimensionVolumeUnitResponseDto>().ReverseMap();
    }
}
