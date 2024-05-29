namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.ResponseDtos;

public class OrderAttributeValueOrderAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public OrderAttributeValueAttributeInputTypeResponseDto AttributeInputType { get; set; }
}
