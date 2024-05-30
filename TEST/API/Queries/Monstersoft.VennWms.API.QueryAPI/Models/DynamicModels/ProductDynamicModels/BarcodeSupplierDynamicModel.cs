using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ProductDynamicModels;

public class BarcodeSupplierDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BarcodeSuppliersDetailLevel? DetailLevel { get; set; }
}

