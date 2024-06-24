using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.DtoProfiles;

public class StockDtoMappingProfiles : Profile
{
    public StockDtoMappingProfiles()
    {
        CreateMap<Stock, CreateStockDto>().ReverseMap();
        CreateMap<Stock, UpdateStockDto>().ReverseMap();

        CreateMap<AttributeInputType, StocksAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, StocksCompanyResponseDto>().ReverseMap();
        CreateMap<ContainerUnit, StocksContainerUnitResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StocksCuItemUnitResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, StocksDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, StocksDepositorResponseDto>().ReverseMap();
        CreateMap<ItemPackType, StocksItemPackTypeResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StocksItemUnitResponseDto>().ReverseMap();
        CreateMap<Unit, StocksLenghtUnitResponseDto>().ReverseMap();
        CreateMap<Location, StocksLocationResponseDto>().ReverseMap();
        CreateMap<ProductBarcode, StocksProductBarcodeResponseDto>().ReverseMap();
        CreateMap<Product, StocksProductResponseDto>().ReverseMap();
        CreateMap<Receipt, StocksReceiptResponseDto>().ReverseMap();
        CreateMap<ReserveReason, StocksReserveReasonResponseDto>().ReverseMap();
        CreateMap<Return, StocksReturnResponseDto>().ReverseMap();
        CreateMap<StockAttribute, StocksStockAttributeResponseDto>().ReverseMap();
        CreateMap<StockAttributeValue, StocksStockAttributeValueResponseDto>().ReverseMap();
        CreateMap<StockContainer, StocksStockContainerResponseDto>().ReverseMap();
        CreateMap<StockInbound, StocksStockInboundResponseDto>().ReverseMap();
        CreateMap<StockMemo, StocksStockMemoResponseDto>().ReverseMap();
        CreateMap<StockPackType, StocksStockPackTypeResponseDto>().ReverseMap();
        CreateMap<StockReserveReason, StocksStockReserveReasonResponseDto>().ReverseMap();
        CreateMap<StockUnsuitReason, StocksStockUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<Unit, StocksUnitResponseDto>().ReverseMap();
        CreateMap<UnsuitReason, StocksUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<Unit, StocksVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, StocksWeightUnitResponseDto>().ReverseMap();

    }
}
