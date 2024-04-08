namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;

public class CreatedProductAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }

}

