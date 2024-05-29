namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.UpdateDtos;

public class UpdateStockPackTypeDto
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

