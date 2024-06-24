using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnItemMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnItemMemosDetailLevel? DetailLevel { get; set; }
}

