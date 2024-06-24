using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockAttributeValues.Dtos.DtoProfiles;

public class LogStockAttributeValueDtoMappingProfiles : Profile
{
    public LogStockAttributeValueDtoMappingProfiles()
    {
        CreateMap<LogStockAttributeValue, CreateLogStockAttributeValueDto>().ReverseMap();
        CreateMap<LogStockAttributeValue, CreateLogStockAttributeValueSubDto>().ReverseMap();
        CreateMap<LogStockAttributeValue, UpdateLogStockAttributeValueDto>().ReverseMap();
        CreateMap<LogStockAttributeValue, UpdateLogStockAttributeValueSubDto>().ReverseMap();
    }
}
