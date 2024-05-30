using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.DtoProfiles;

public class StockPackTypeDtoMappingProfiles : Profile
{
    public StockPackTypeDtoMappingProfiles()
    {
        CreateMap<StockPackType, CreateStockPackTypeDto>().ReverseMap();
        CreateMap<StockPackType, CreateStockPackTypeSubDto>().ReverseMap();
        CreateMap<StockPackType, UpdateStockPackTypeDto>().ReverseMap();
        CreateMap<StockPackType, UpdateStockPackTypeSubDto>().ReverseMap();

        CreateMap<Company, StockPackTypesCompanyResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StockPackTypesCuItemUnitResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, StockPackTypesDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, StockPackTypesDepositorResponseDto>().ReverseMap();
        CreateMap<ItemUnit, StockPackTypesItemUnitResponseDto>().ReverseMap();
        CreateMap<Location, StockPackTypesLocationResponseDto>().ReverseMap();
        CreateMap<Product, StockPackTypesProductResponseDto>().ReverseMap();
        CreateMap<Stock, StockPackTypesStockResponseDto>().ReverseMap();
        CreateMap<Unit, StockPackTypesUnitResponseDto>().ReverseMap();
    }
}
