using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnItemDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnItemsDetailLevel? DetailLevel { get; set; }
}

