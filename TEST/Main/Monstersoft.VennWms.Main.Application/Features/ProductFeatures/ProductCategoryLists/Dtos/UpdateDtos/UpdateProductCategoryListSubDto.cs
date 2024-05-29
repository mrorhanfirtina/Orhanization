namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.UpdateDtos;

public class UpdateProductCategoryListSubDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public int Priority { get; set; }
    public Guid DepositorCompanyId { get; set; }
}

