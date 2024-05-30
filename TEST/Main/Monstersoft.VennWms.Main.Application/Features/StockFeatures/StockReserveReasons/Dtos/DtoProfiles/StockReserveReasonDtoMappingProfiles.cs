using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockReserveReasons.Dtos.DtoProfiles;

public class StockReserveReasonDtoMappingProfiles : Profile
{
    public StockReserveReasonDtoMappingProfiles()
    {
        CreateMap<StockReserveReason, CreateStockReserveReasonDto>().ReverseMap();
        CreateMap<StockReserveReason, CreateStockReserveReasonSubDto>().ReverseMap();
        CreateMap<StockReserveReason, UpdateStockReserveReasonDto>().ReverseMap();
        CreateMap<StockReserveReason, UpdateStockReserveReasonSubDto>().ReverseMap();

        CreateMap<ReserveReason, StockReserveReasonsReserveReasonResponseDto>().ReverseMap();
        CreateMap<Stock, StockReserveReasonsStockResponseDto>().ReverseMap();
    }
}
