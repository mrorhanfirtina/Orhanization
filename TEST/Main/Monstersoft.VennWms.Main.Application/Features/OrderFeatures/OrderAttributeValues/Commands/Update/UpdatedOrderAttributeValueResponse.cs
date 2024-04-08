namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Commands.Update;

public class UpdatedOrderAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
