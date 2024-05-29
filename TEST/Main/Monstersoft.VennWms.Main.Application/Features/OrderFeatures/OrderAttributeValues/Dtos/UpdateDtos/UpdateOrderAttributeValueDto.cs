namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.UpdateDtos;

public class UpdateOrderAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }

}

