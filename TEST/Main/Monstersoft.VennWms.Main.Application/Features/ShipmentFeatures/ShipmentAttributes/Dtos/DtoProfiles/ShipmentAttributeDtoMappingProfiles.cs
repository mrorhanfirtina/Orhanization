using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributes.Dtos.DtoProfiles;

public class ShipmentAttributeDtoMappingProfiles : Profile
{
    public ShipmentAttributeDtoMappingProfiles()
    {
        CreateMap<ShipmentAttribute, CreateShipmentAttributeDto>().ReverseMap();
        CreateMap<ShipmentAttribute, UpdateShipmentAttributeDto>().ReverseMap();

        CreateMap<AttributeInputType, ShipmentAttributesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ShipmentAttributesDepositorCompanyResponseDto>().ReverseMap();
    }
}
