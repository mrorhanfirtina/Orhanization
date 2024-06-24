using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnMemosDetailLevel? DetailLevel { get; set; }
}

