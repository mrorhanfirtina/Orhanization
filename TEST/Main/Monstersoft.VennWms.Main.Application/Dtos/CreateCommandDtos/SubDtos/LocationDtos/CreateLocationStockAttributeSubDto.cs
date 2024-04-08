namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

public class CreateLocationStockAttributeSubDto
{
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}
