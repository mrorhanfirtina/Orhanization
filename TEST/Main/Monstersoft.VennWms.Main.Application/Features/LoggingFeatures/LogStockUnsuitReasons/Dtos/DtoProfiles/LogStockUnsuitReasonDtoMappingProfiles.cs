using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons;

public class LogStockUnsuitReasonDtoMappingProfiles : Profile
{
    public LogStockUnsuitReasonDtoMappingProfiles()
    {
        CreateMap<LogStockUnsuitReason, CreateLogStockUnsuitReasonDto>().ReverseMap();
        CreateMap<LogStockUnsuitReason, CreateLogStockUnsuitReasonSubDto>().ReverseMap();
        CreateMap<LogStockUnsuitReason, UpdateLogStockUnsuitReasonDto>().ReverseMap();
        CreateMap<LogStockUnsuitReason, UpdateLogStockUnsuitReasonSubDto>().ReverseMap();
    }
}
