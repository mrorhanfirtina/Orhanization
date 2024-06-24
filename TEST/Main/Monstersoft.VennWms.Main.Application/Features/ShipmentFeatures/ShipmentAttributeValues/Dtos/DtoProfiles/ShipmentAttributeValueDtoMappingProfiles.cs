using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.DtoProfiles;

public class ShipmentAttributeValueDtoMappingProfiles : Profile
{
    public ShipmentAttributeValueDtoMappingProfiles()
    {
        CreateMap<ShipmentAttributeValue, CreateShipmentAttributeValueDto>().ReverseMap();
        CreateMap<ShipmentAttributeValue, CreateShipmentAttributeValueSubDto>().ReverseMap();
        CreateMap<ShipmentAttributeValue, UpdateShipmentAttributeValueDto>().ReverseMap();
        CreateMap<ShipmentAttributeValue, UpdateShipmentAttributeValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ShipmentAttributeValuesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<ShipmentAttribute, ShipmentAttributeValuesShipmentAttributeResponseDto>().ReverseMap();
        CreateMap<Shipment, ShipmentAttributeValuesShipmentResponseDto>().ReverseMap();
    }
}
