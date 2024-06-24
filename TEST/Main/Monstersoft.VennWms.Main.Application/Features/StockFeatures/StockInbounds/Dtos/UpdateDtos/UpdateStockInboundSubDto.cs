﻿namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures;

public class UpdateStockInboundSubDto
{
    public Guid? ReceiptId { get; set; }
    public Guid? ReturnId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
}
