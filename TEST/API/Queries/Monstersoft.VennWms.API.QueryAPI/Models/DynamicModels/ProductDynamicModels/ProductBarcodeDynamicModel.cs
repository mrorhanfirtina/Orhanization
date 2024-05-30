using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class ProductBarcodeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ProductBarcodesDetailLevel? DetailLevel { get; set; }
}

