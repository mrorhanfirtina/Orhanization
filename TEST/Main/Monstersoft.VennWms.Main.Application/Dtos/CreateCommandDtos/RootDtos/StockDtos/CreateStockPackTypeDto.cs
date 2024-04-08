namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.StockDtos;

public class CreateStockPackTypeDto
{
    public Guid StockId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal Quantity { get; set; }
    public decimal QuantityFree { get; set; }
    public decimal PackTypeRatio { get; set; }
    public decimal CUQuantity { get; set; }
    public decimal CUQuantityFree { get; set; }
}

