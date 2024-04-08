namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Queries.GetById;

public class GetByIdOrderAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid OrderAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
