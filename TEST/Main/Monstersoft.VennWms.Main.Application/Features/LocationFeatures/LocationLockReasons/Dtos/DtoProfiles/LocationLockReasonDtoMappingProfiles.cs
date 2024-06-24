using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationLockReasons.Dtos.DtoProfiles;

public class LocationLockReasonDtoMappingProfiles : Profile
{
    public LocationLockReasonDtoMappingProfiles()
    {
        CreateMap<LocationLockReason, CreateLocationLockReasonDto>().ReverseMap();
        CreateMap<LocationLockReason, CreateLocationLockReasonSubDto>().ReverseMap();
        CreateMap<LocationLockReason, UpdateLocationLockReasonDto>().ReverseMap();
        CreateMap<LocationLockReason, UpdateLocationLockReasonSubDto>().ReverseMap();

        CreateMap<Location, LocationLockReasonLocationResponseDto>().ReverseMap();
        CreateMap<LockReason, LocationLockReasonLockReasonResponseDto>().ReverseMap();
    }
}
