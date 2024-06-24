using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationUnitConstraints.Dtos.DtoProfiles;

public class LocationUnitConstraintDtoMappingProfiles : Profile
{
    public LocationUnitConstraintDtoMappingProfiles()
    {
        CreateMap<LocationUnitConstraint, CreateLocationUnitConstraintDto>().ReverseMap();
        CreateMap<LocationUnitConstraint, CreateLocationUnitConstraintSubDto>().ReverseMap();
        CreateMap<LocationUnitConstraint, UpdateLocationUnitConstraintDto>().ReverseMap();
        CreateMap<LocationUnitConstraint, UpdateLocationUnitConstraintSubDto>().ReverseMap();

        CreateMap<Location, LocationUnitConstraintLocationResponseDto>().ReverseMap();
        CreateMap<Unit, LocationUnitConstraintUnitResponseDto>().ReverseMap();
    }
}
