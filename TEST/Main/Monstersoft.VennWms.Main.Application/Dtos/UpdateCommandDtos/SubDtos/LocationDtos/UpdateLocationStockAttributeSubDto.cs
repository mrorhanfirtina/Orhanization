namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

public class UpdateLocationStockAttributeSubDto
{
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
