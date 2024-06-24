using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoProfiles;

public class ReturnDtoMappingProfiles : Profile
{
    public ReturnDtoMappingProfiles()
    {
        CreateMap<Return, CreateReturnDto>().ReverseMap();
        CreateMap<Return, CreateReturnSubDto>().ReverseMap();
        CreateMap<Return, UpdateReturnDto>().ReverseMap();
        CreateMap<Return, UpdateReturnSubDto>().ReverseMap();

        CreateMap<Address, ReturnsAddressResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, ReturnsAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, ReturnsCompanyResponseDto>().ReverseMap();
        CreateMap<Customer, ReturnsCustomerResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ReturnsDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, ReturnsDepositorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ReturnsItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ReturnsProductResponseDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, ReturnsReceiptItemMemoResponseDto>().ReverseMap();
        CreateMap<ReturnAttribute, ReturnsReturnAttributeResponseDto>().ReverseMap();
        CreateMap<ReturnAttributeValue, ReturnsReturnAttributeValueResponseDto>().ReverseMap();
        CreateMap<ReturnItemMemo, ReturnsReturnItemMemoResponseDto>().ReverseMap();
        CreateMap<ReturnItem, ReturnsReturnItemResponseDto>().ReverseMap();
        CreateMap<ReturnItmStockAttrValue, ReturnsReturnItmStockAttrValueResponseDto>().ReverseMap();
        CreateMap<ReturnMemo, ReturnsReturnMemoResponseDto>().ReverseMap();
        CreateMap<ReturnType, ReturnsReturnTypeResponseDto>().ReverseMap();
        CreateMap<Status, ReturnsStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReturnsStockAttributeResponseDto>().ReverseMap();
        CreateMap<Unit, ReturnsUnitResponseDto>().ReverseMap();
    }
}
