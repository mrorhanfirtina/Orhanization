namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.CreateDtos;

public class CreateLocationProductDto
{
    public Guid LocationId { get; set; }
    public Guid ProductId { get; set; }
    public bool IsForbid { get; set; }
}

