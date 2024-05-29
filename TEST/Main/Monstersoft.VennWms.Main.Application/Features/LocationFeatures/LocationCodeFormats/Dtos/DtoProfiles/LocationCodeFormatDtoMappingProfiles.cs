using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationCodeFormats.Dtos.DtoProfiles;

public class LocationCodeFormatDtoMappingProfiles : Profile
{
    public LocationCodeFormatDtoMappingProfiles()
    {
        CreateMap<LocationCodeFormat, CreateLocationCodeFormatDto>().ReverseMap();
        CreateMap<LocationCodeFormat, CreateLocationCodeFormatSubDto>().ReverseMap();
        CreateMap<LocationCodeFormat, UpdateLocationCodeFormatDto>().ReverseMap();
        CreateMap<LocationCodeFormat, UpdateLocationCodeFormatSubDto>().ReverseMap();

        CreateMap<Location, LocationCodeFormatLocationResponseDto>().ReverseMap();
    }
}
