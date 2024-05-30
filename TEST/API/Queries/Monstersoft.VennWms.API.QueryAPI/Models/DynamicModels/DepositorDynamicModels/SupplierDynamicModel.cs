using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class SupplierDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SuppliersDetailLevel? DetailLevel { get; set; }
}

