﻿namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.ResponseDtos;

public class WorkTasksStockResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public decimal CuQuantity { get; set; }
    public decimal CuQuantityFree { get; set; }
    public Guid LocationId { get; set; }
    public Guid CuItemUnitId { get; set; }
    public WorkTasksProductResponseDto? Product { get; set; }
}
