using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class CustomerDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public CustomersDetailLevel? DetailLevel { get; set; }
}

