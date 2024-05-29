namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

public class OrderOrderAttributeValueResponseDto
{
    public Guid Id { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }
    public OrderOrderAttributeResponseDto? OrderAttribute { get; set; }
}
