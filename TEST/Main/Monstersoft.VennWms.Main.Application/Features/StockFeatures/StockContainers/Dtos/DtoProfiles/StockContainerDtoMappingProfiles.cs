using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.DtoProfiles;

public class StockContainerDtoMappingProfiles : Profile
{
    public StockContainerDtoMappingProfiles()
    {
        CreateMap<StockContainer, CreateStockContainerDto>().ReverseMap();
        CreateMap<StockContainer, CreateStockContainerSubDto>().ReverseMap();
        CreateMap<StockContainer, UpdateStockContainerDto>().ReverseMap();
        CreateMap<StockContainer, UpdateStockContainerSubDto>().ReverseMap();

        CreateMap<AttributeInputType, StockContainersAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<Company, StockContainersCompanyResponseDto>().ReverseMap();
        CreateMap<ContainerUnit, StockContainersContainerUnitResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StockContainersCuItemUnitResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, StockContainersDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, StockContainersDepositorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StockContainersItemUnitResponseDto>().ReverseMap();
        CreateMap<Location, StockContainersLocationResponseDto>().ReverseMap();
        CreateMap<ReserveReason, StockContainersReserveReasonResponseDto>().ReverseMap();
        CreateMap<Product, StockContainersProductResponseDto>().ReverseMap();
        CreateMap<StockAttribute, StockContainersStockAttributeResponseDto>().ReverseMap();
        CreateMap<StockAttributeValue, StockContainersStockAttributeValueResponseDto>().ReverseMap();
        CreateMap<StockMemo, StockContainersStockMemoResponseDto>().ReverseMap();
        CreateMap<StockReserveReason, StockContainersStockReserveReasonResponseDto>().ReverseMap();
        CreateMap<Stock, StockContainersStockResponseDto>().ReverseMap();
        CreateMap<StockUnsuitReason, StockContainersStockUnsuitReasonResponseDto>().ReverseMap();
        CreateMap<Unit, StockContainersUnitResponseDto>().ReverseMap();
        CreateMap<UnsuitReason, StockContainersUnsuitReasonResponseDto>().ReverseMap();
    }
}
