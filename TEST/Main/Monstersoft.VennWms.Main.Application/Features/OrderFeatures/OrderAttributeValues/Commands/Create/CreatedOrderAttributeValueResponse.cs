using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Create;

public class CreatedOrderAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderAttributeValueOrderResponseDto? Order { get; set; }
    public OrderAttributeValueOrderAttributeResponseDto? OrderAttribute { get; set; }
}
