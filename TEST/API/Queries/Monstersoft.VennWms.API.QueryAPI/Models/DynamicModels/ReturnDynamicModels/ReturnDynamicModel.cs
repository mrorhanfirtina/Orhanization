using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ReturnDynamicModels;

public class ReturnDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReturnsDetailLevel? DetailLevel { get; set; }
}

