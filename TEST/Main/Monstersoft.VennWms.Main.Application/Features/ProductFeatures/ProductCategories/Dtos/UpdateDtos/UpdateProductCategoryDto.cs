namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.UpdateDtos;

public class UpdateProductCategoryDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int CategoryId { get; set; }
}
