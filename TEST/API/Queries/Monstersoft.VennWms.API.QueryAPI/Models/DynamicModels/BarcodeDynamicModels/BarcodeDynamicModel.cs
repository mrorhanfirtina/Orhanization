using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;

public class BarcodeDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BarcodesDetailLevel? DetailLevel { get; set; }
}

