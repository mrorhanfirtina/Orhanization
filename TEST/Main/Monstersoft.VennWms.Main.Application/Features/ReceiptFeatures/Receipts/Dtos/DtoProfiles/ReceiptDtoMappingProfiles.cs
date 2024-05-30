using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoProfiles;

public class ReceiptDtoMappingProfiles : Profile
{
    public ReceiptDtoMappingProfiles()
    {
        CreateMap<Receipt, CreateReceiptDto>().ReverseMap();
        CreateMap<Receipt, CreateReceiptSubDto>().ReverseMap();
        CreateMap<Receipt, UpdateReceiptDto>().ReverseMap();
        CreateMap<Receipt, UpdateReceiptSubDto>().ReverseMap();

        CreateMap<AttributeInputType, ReceiptsAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, ReceiptsCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ReceiptsDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, ReceiptsDepositorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ReceiptsItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ReceiptsProductResponseDto>().ReverseMap();
        CreateMap<PurchaseOrder, ReceiptsPurchaseOrderResponseDto>().ReverseMap();
        CreateMap<ReceiptAttribute, ReceiptsReceiptAttributeResponseDto>().ReverseMap();
        CreateMap<ReceiptAttributeValue, ReceiptsReceiptAttributeValueResponseDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, ReceiptsReceiptItemMemoResponseDto>().ReverseMap();
        CreateMap<ReceiptItem, ReceiptsReceiptItemResponseDto>().ReverseMap();
        CreateMap<ReceiptItmStockAttrValue, ReceiptsReceiptItmStockAttrValueResponseDto>().ReverseMap();
        CreateMap<ReceiptMemo, ReceiptsReceiptMemoResponseDto>().ReverseMap();
        CreateMap<ReceiptType, ReceiptsReceiptTypeResponseDto>().ReverseMap();
        CreateMap<Status, ReceiptsStatusResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ReceiptsStockAttributeResponseDto>().ReverseMap();
        CreateMap<Supplier, ReceiptsSupplierResponseDto>().ReverseMap();
        CreateMap<Unit, ReceiptsUnitResponseDto>().ReverseMap();
    }
}
