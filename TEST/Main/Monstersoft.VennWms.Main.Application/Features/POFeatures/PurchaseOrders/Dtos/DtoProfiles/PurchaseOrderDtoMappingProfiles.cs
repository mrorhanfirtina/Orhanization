using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.DtoProfiles;

public class PurchaseOrderDtoMappingProfiles : Profile
{
    public PurchaseOrderDtoMappingProfiles()
    {
        CreateMap<PurchaseOrder, CreatePurchaseOrderDto>().ReverseMap();
        CreateMap<PurchaseOrder, CreatePurchaseOrderSubDto>().ReverseMap();
        CreateMap<PurchaseOrder, UpdatePurchaseOrderDto>().ReverseMap();
        CreateMap<PurchaseOrder, UpdatePurchaseOrderSubDto>().ReverseMap();

        CreateMap<Address, PurchaseOrderAddressResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, PurchaseOrderAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, PurchaseOrderCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, PurchaseOrderDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, PurchaseOrderDepositorResponseDto>().ReverseMap();
        CreateMap<PoAttribute, PurchaseOrderPoAttributeResponseDto>().ReverseMap();
        CreateMap<PoAttributeValue, PurchaseOrderPoAttributeValueResponseDto>().ReverseMap();
        CreateMap<PoMemo, PurchaseOrderPoMemoResponseDto>().ReverseMap();
        CreateMap<PoType, PurchaseOrderPoTypeResponseDto>().ReverseMap();
        CreateMap<Receipt, PurchaseOrderReceiptResponseDto>().ReverseMap();
        CreateMap<Status, PurchaseOrderStatusResponseDto>().ReverseMap();
        CreateMap<Supplier, PurchaseOrderSupplierResponseDto>().ReverseMap();
    }
}
