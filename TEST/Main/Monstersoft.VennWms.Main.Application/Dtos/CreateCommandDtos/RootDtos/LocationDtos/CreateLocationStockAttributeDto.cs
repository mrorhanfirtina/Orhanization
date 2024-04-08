namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

public class CreateLocationStockAttributeDto
{
    public Guid LocationId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public bool IsForbid { get; set; }
}

