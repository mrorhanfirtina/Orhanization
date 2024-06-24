using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.BarcodeDynamicModels;

public class PrinterDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PrintersDetailLevel? DetailLevel { get; set; }
}

