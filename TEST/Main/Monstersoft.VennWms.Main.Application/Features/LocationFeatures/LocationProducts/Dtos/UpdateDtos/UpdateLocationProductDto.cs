namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.UpdateDtos;

public class UpdateLocationProductDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
}

