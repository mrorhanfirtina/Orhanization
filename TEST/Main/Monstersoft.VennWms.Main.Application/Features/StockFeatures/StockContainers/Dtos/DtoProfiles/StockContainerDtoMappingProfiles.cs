using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.UpdateDtos;
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
    }
}
