using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.DtoProfiles;

public class ShipmentTypeDtoMappingProfiles : Profile
{
    public ShipmentTypeDtoMappingProfiles()
    {
        CreateMap<ShipmentType, CreateShipmentTypeDto>().ReverseMap();
        CreateMap<ShipmentType, CreateShipmentTypeSubDto>().ReverseMap();
        CreateMap<ShipmentType, UpdateShipmentTypeDto>().ReverseMap();
        CreateMap<ShipmentType, UpdateShipmentTypeSubDto>().ReverseMap();
    }
}
