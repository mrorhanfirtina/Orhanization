using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductConstraints.Dtos.DtoProfiles;

public class LocationProductConstraintDtoMappingProfiles : Profile
{
    public LocationProductConstraintDtoMappingProfiles()
    {
        CreateMap<LocationProductConstraint, CreateLocationProductConstraintDto>().ReverseMap();
        CreateMap<LocationProductConstraint, CreateLocationProductConstraintSubDto>().ReverseMap();
        CreateMap<LocationProductConstraint, UpdateLocationProductConstraintDto>().ReverseMap();
        CreateMap<LocationProductConstraint, UpdateLocationProductConstraintSubDto>().ReverseMap();

        CreateMap<ItemUnit, LocationProductConstraintItemUnitResponseDto>().ReverseMap();
        CreateMap<Location, LocationProductConstraintLocationResponseDto>().ReverseMap();
        CreateMap<Product, LocationProductConstraintProductResponseDto>().ReverseMap();
        CreateMap<Unit, LocationProductConstraintUnitResponseDto>().ReverseMap();
    }
}
