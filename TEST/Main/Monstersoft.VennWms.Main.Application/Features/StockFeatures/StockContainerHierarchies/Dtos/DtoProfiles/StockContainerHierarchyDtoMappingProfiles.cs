using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoProfiles;

public class StockContainerHierarchyDtoMappingProfiles : Profile
{
    public StockContainerHierarchyDtoMappingProfiles()
    {
        CreateMap<StockContainerHierarchy, CreateStockContainerHierarchyDto>().ReverseMap();
        CreateMap<StockContainerHierarchy, CreateStockContainerHierarchySubDto>().ReverseMap();
        CreateMap<StockContainerHierarchy, UpdateStockContainerHierarchyDto>().ReverseMap();
        CreateMap<StockContainerHierarchy, UpdateStockContainerHierarchySubDto>().ReverseMap();

        CreateMap<StockContainerHierarchyContainerResponseDto, StockContainer>().ReverseMap();
        CreateMap<StockContainerHierarchyContainerUnitResponseDto, ContainerUnit>().ReverseMap();
        CreateMap<StockContainerHierarchyStockResponseDto, Stock>().ReverseMap();
        CreateMap<StockContainerHierarchyProductResponseDto, Product>().ReverseMap();
        CreateMap<StockContainerHierarchyDepositorResponseDto, Depositor>().ReverseMap();
        CreateMap<StockContainerHierarchyDepositorCompanyResponseDto, DepositorCompany>().ReverseMap();
        CreateMap<StockContainerHierarchyLocationResponseDto, Location>().ReverseMap();
        CreateMap<StockContainerHierarchyItemUnitResponseDto, ItemUnit>().ReverseMap();
        CreateMap<StockContainerHierarchyUnitResponseDto, Unit>().ReverseMap();
    }
}
