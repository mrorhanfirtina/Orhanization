namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributes.Dtos.CreateDtos;

public class CreateStockAttributeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

