using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class ShipmentMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ShipmentMemosDetailLevel? DetailLevel { get; set; }
}

