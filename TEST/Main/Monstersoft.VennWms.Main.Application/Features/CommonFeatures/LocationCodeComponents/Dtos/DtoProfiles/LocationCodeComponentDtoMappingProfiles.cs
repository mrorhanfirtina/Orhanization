using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.DtoProfiles;

public class LocationCodeComponentDtoMappingProfiles : Profile
{
    public LocationCodeComponentDtoMappingProfiles()
    {
        CreateMap<LocationCodeComponent, CreateLocationCodeComponentDto>().ReverseMap();
        CreateMap<LocationCodeComponent, UpdateLocationCodeComponentDto>().ReverseMap();
    }
}
