using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.DtoProfiles;

public class StockUnsuitReasonDtoMappingProfiles : Profile
{
    public StockUnsuitReasonDtoMappingProfiles()
    {
        CreateMap<StockUnsuitReason, CreateStockUnsuitReasonDto>().ReverseMap();
        CreateMap<StockUnsuitReason, CreateStockUnsuitReasonSubDto>().ReverseMap();
        CreateMap<StockUnsuitReason, UpdateStockUnsuitReasonDto>().ReverseMap();
        CreateMap<StockUnsuitReason, UpdateStockUnsuitReasonSubDto>().ReverseMap();
    }
}
