using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetById;

public class GetByIdProductResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    public ICollection<ProductBarcode> ProductBarcodes { get; set; }
    public ICollection<ItemUnit> ItemUnits { get; set; }

}
