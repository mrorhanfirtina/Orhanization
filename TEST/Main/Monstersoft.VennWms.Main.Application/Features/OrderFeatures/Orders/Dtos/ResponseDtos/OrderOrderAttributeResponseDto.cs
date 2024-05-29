namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public OrderAttributeInputTypeResponseDto AttributeInputType { get; set; }
}
