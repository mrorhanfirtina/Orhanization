using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.DtoProfiles;

public class ShipmentMemoDtoMappingProfiles : Profile
{
    public ShipmentMemoDtoMappingProfiles()
    {
        CreateMap<ShipmentMemo, CreateShipmentMemoDto>().ReverseMap();
        CreateMap<ShipmentMemo, CreateShipmentMemoSubDto>().ReverseMap();
        CreateMap<ShipmentMemo, UpdateShipmentMemoDto>().ReverseMap();
        CreateMap<ShipmentMemo, UpdateShipmentMemoSubDto>().ReverseMap();
    }
}
