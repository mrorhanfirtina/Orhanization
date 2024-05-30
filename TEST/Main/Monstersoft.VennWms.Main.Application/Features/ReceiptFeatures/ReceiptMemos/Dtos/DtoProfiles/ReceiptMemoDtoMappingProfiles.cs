using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptMemos.Dtos.DtoProfiles;

public class ReceiptMemoDtoMappingProfiles : Profile
{
    public ReceiptMemoDtoMappingProfiles()
    {
        CreateMap<ReceiptMemo, CreateReceiptMemoDto>().ReverseMap();
        CreateMap<ReceiptMemo, CreateReceiptMemoSubDto>().ReverseMap();
        CreateMap<ReceiptMemo, UpdateReceiptMemoDto>().ReverseMap();
        CreateMap<ReceiptMemo, UpdateReceiptMemoSubDto>().ReverseMap();

        CreateMap<Receipt, ReceiptMemosReceiptResponseDto>().ReverseMap();
    }
}
