using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoProfiles;

public class ShipmentDtoMappingProfiles : Profile
{
    public ShipmentDtoMappingProfiles()
    {
        CreateMap<Shipment, CreateShipmentDto>().ReverseMap();
        CreateMap<Shipment, CreateShipmentSubDto>().ReverseMap();
        CreateMap<Shipment, UpdateShipmentDto>().ReverseMap();
        CreateMap<Shipment, UpdateShipmentSubDto>().ReverseMap();

        CreateMap<Address, ShipmentsAddressResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, ShipmentsAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Branch, ShipmentsBranchResponseDto>().ReverseMap();
        CreateMap<Company, ShipmentsCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ShipmentsDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, ShipmentsDepositorResponseDto>().ReverseMap();
        CreateMap<Distributor, ShipmentsDistributorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ShipmentsItemUnitResponseDto>().ReverseMap();
        CreateMap<OrderItem, ShipmentsOrderItemResponseDto>().ReverseMap();
        CreateMap<Order, ShipmentsOrderResponseDto>().ReverseMap();
        CreateMap<OrderShipItem, ShipmentsOrderShipItemResponseDto>().ReverseMap();
        CreateMap<OrderShipItemStock, ShipmentsOrderShipItemStockResponseDto>().ReverseMap();
        CreateMap<OrderShipItemTask, ShipmentsOrderShipItemTaskResponseDto>().ReverseMap();
        CreateMap<OrderShipment, ShipmentsOrderShipmentResponseDto>().ReverseMap();
        CreateMap<Product, ShipmentsProductResponseDto>().ReverseMap();
        CreateMap<ProgressStatus, ShipmentsProgressStatusResponseDto>().ReverseMap();
        CreateMap<ShipmentAttribute, ShipmentsShipmentAttributeResponseDto>().ReverseMap();
        CreateMap<ShipmentAttributeValue, ShipmentsShipmentAttributeValueResponseDto>().ReverseMap();
        CreateMap<ShipmentMemo, ShipmentsShipmentMemoResponseDto>().ReverseMap();
        CreateMap<ShipmentType, ShipmentsShipmentTypeResponseDto>().ReverseMap();
        CreateMap<StockPackType, ShipmentsStockPackTypeResponseDto>().ReverseMap();
        CreateMap<Stock, ShipmentsStockResponseDto>().ReverseMap();
        CreateMap<Unit, ShipmentsUnitResponseDto>().ReverseMap();

    }
}
