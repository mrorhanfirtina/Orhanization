using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.DtoProfiles;

public class LogStockReserveReasonDtoMappingProfiles : Profile
{
    public LogStockReserveReasonDtoMappingProfiles()
    {
        CreateMap<LogStockReserveReason, CreateLogStockReserveReasonDto>().ReverseMap();
        CreateMap<LogStockReserveReason, CreateLogStockReserveReasonSubDto>().ReverseMap();
        CreateMap<LogStockReserveReason, UpdateLogStockReserveReasonDto>().ReverseMap();
        CreateMap<LogStockReserveReason, UpdateLogStockReserveReasonSubDto>().ReverseMap();
    }
}
