using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockContainers.Dtos.DtoProfiles;

public class LogStockContainerDtoMappingProfiles : Profile
{
    public LogStockContainerDtoMappingProfiles()
    {
        CreateMap<LogStockContainer, CreateLogStockContainerDto>().ReverseMap();
        CreateMap<LogStockContainer, CreateLogStockContainerSubDto>().ReverseMap();
        CreateMap<LogStockContainer, UpdateLogStockContainerDto>().ReverseMap();
        CreateMap<LogStockContainer, UpdateLogStockContainerSubDto>().ReverseMap();
    }
}
