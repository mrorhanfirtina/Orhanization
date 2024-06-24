using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.DtoProfiles;

public class LocationDepositorDtoMappingProfiles : Profile
{
    public LocationDepositorDtoMappingProfiles()
    {
        CreateMap<LocationDepositor, CreateLocationDepositorDto>().ReverseMap();
        CreateMap<LocationDepositor, CreateLocationDepositorSubDto>().ReverseMap();
        CreateMap<LocationDepositor, UpdateLocationDepositorDto>().ReverseMap();
        CreateMap<LocationDepositor, UpdateLocationDepositorSubDto>().ReverseMap();

        CreateMap<Depositor, LocationDepositorDepositorResponseDto>().ReverseMap();
        CreateMap<Location, LocationDepositorLocationResponseDto>().ReverseMap();
    }
}
