namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;

public class BarcodeAreaDetailLevel
{
    public bool IncludeBarcode { get; set; } = false;
    public BarcodeAreaBarcodeDetailLevel BarcodeDetailLevel { get; set; } = new BarcodeAreaBarcodeDetailLevel();

    public class BarcodeAreaBarcodeDetailLevel
    {
        public bool IncludeDepositorCompany { get; set; } = false;
    }
}
