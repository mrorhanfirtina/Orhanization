using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.DtoProfiles;

public class BufferLocationDtoMappingProfiles : Profile
{
    public BufferLocationDtoMappingProfiles()
    {
        CreateMap<BufferLocation, CreateBufferLocationDto>().ReverseMap();
        CreateMap<BufferLocation, CreateBufferLocationSubDto>().ReverseMap();
        CreateMap<BufferLocation, UpdateBufferLocationDto>().ReverseMap();
        CreateMap<BufferLocation, UpdateBufferLocationSubDto>().ReverseMap();

        CreateMap<Location, BufferLocationLocationResponseDto>().ReverseMap();
    }
}
