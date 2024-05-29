using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.DtoProfiles;

public class ReceiptItemDtoMappingProfiles : Profile
{
    public ReceiptItemDtoMappingProfiles()
    {
        CreateMap<ReceiptItem, CreateReceiptItemDto>().ReverseMap();
        CreateMap<ReceiptItem, CreateReceiptItemSubDto>().ReverseMap();
        CreateMap<ReceiptItem, UpdateReceiptItemDto>().ReverseMap();
        CreateMap<ReceiptItem, UpdateReceiptItemSubDto>().ReverseMap();
    }
}
