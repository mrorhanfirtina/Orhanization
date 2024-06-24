namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.CreateDtos;

public class CreateOrderAttributeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

