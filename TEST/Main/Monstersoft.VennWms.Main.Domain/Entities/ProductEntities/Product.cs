using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

public class Product : Entity<Guid>
{
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    public virtual ICollection<ProductBarcode> ProductBarcodes { get; set; }
    public virtual ICollection<ProductDepositor> ProductDepositors { get; set; }
    public virtual ICollection<ItemUnit> ItemUnits { get; set; }
    public virtual ICollection<ProductStockAttribute> ProductStockAttributes { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }


    public Product()
    {
        ProductAttributeValues = new HashSet<ProductAttributeValue>();
        ProductBarcodes = new HashSet<ProductBarcode>();
        ItemUnits = new HashSet<ItemUnit>();
        ProductDepositors = new HashSet<ProductDepositor>();
        ProductStockAttributes = new HashSet<ProductStockAttribute>();
    }

    public Product(Guid id, string code, string description,Guid depositorCompanyId , string alternativeCode) : this()
    {
        Id = id;
        Code = code;
        Description = description;
        AlternativeCode = alternativeCode;
        DepositorCompanyId = depositorCompanyId;
    }
}
