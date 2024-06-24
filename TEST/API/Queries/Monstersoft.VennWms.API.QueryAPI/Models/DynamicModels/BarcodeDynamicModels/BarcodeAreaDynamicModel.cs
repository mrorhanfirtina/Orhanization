using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;

public class BarcodeAreaDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BarcodeAreasDetailLevel? DetailLevel { get; set; }
}

