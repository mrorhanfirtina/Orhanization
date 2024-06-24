using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.DtoProfiles;

public class LocationPriorityDtoMappingProfiles : Profile
{
    public LocationPriorityDtoMappingProfiles()
    {
        CreateMap<LocationPriority, CreateLocationPriorityDto>().ReverseMap();
        CreateMap<LocationPriority, CreateLocationPrioritySubDto>().ReverseMap();
        CreateMap<LocationPriority, UpdateLocationPriorityDto>().ReverseMap();
        CreateMap<LocationPriority, UpdateLocationPrioritySubDto>().ReverseMap();

        CreateMap<Location, LocationPriorityLocationResponseDto>().ReverseMap();
    }
}
