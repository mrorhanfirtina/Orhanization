using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoProfiles;

public class ReceiptDtoMappingProfiles : Profile
{
    public ReceiptDtoMappingProfiles()
    {
        CreateMap<Receipt, CreateReceiptDto>().ReverseMap();
        CreateMap<Receipt, CreateReceiptSubDto>().ReverseMap();
        CreateMap<Receipt, UpdateReceiptDto>().ReverseMap();
        CreateMap<Receipt, UpdateReceiptSubDto>().ReverseMap();
    }
}
