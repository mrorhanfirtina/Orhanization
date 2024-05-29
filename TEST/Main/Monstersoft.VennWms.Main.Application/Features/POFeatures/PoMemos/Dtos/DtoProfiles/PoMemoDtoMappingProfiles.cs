using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoProfiles;

public class PoMemoDtoMappingProfiles : Profile
{
    public PoMemoDtoMappingProfiles()
    {
        CreateMap<PoMemo, CreatePoMemoDto>().ReverseMap();
        CreateMap<PoMemo, CreatePoMemoSubDto>().ReverseMap();
        CreateMap<PoMemo, UpdatePoMemoDto>().ReverseMap();
        CreateMap<PoMemo, UpdatePoMemoSubDto>().ReverseMap();

        CreateMap<PurchaseOrder, PoMemoPurchaseOrderResponseDto>().ReverseMap();
    }
}
