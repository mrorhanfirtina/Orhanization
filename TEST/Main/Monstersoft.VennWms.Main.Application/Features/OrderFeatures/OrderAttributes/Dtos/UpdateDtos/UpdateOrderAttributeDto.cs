namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.UpdateDtos;

public class UpdateOrderAttributeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

