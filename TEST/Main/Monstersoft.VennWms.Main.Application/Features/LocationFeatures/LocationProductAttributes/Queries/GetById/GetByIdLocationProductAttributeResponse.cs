namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProductAttributes.Queries.GetById;

public class GetByIdLocationProductAttributeResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductAttributeId { get; set; }
    public bool IsForbid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

