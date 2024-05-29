using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoProfiles;

public class ShipmentDtoMappingProfiles : Profile
{
    public ShipmentDtoMappingProfiles()
    {
        CreateMap<Shipment, CreateShipmentDto>().ReverseMap();
        CreateMap<Shipment, CreateShipmentSubDto>().ReverseMap();
        CreateMap<Shipment, UpdateShipmentDto>().ReverseMap();
        CreateMap<Shipment, UpdateShipmentSubDto>().ReverseMap();
    }
}
