﻿using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockUnsuitReasons.Commands.Update;

public class UpdatedStockUnsuitReasonResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid UnsuitReasonId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockUnsuitReasonsUnsuitReasonResponseDto? UnsuitReason { get; set; }
    public StockUnsuitReasonsStockResponseDto? Stock { get; set; }
}
