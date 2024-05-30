using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;

public class BarcodePrinterDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public BarcodePrintersDetailLevel? DetailLevel { get; set; }
}

