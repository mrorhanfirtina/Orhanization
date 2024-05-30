namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Constants;

public class BarcodeAreasDetailLevel
{
    public bool IncludeBarcode { get; set; } = false;
    public BarcodeAreasBarcodeSubDetailLevel BarcodeDetailLevel { get; set; } = new BarcodeAreasBarcodeSubDetailLevel();

    public class BarcodeAreasBarcodeSubDetailLevel
    {
        public bool IncludeDepositorCompany { get; set; } = false;
    }
}
