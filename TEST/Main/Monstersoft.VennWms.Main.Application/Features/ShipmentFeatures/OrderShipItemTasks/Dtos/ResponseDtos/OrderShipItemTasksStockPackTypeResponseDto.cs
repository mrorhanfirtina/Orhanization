﻿namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Dtos.ResponseDtos;

public class OrderShipItemTasksStockPackTypeResponseDto
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Quantity { get; set; }
    public decimal QuantityFree { get; set; }
    public decimal PackTypeRatio { get; set; }
    public Guid? ParentId { get; set; }
    public decimal? CUQuantity { get; set; }
    public decimal? CUQuantityFree { get; set; }
}