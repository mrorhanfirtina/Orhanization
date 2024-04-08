namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Commands.Update;

public class UpdatedLocationProductAttributeResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

