using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.DtoProfiles;

public class ReturnItemMemoDtoMappingProfiles : Profile
{
    public ReturnItemMemoDtoMappingProfiles()
    {
        CreateMap<ReturnItemMemo, CreateReturnItemMemoDto>().ReverseMap();
        CreateMap<ReturnItemMemo, CreateReturnItemMemoSubDto>().ReverseMap();
        CreateMap<ReturnItemMemo, UpdateReturnItemMemoDto>().ReverseMap();
        CreateMap<ReturnItemMemo, UpdateReturnItemMemoSubDto>().ReverseMap();

        CreateMap<Product, ReturnItemMemosProductResponseDto>().ReverseMap();
        CreateMap<ReturnItem, ReturnItemMemosReturnItemResponseDto>().ReverseMap();
        CreateMap<Return, ReturnItemMemosReturnResponseDto>().ReverseMap();
    }
}
