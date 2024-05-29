namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;

public class BarcodePrinterDetailLevel
{
    public bool IncludeBarcode { get; set; } = false;
    public BarcodePrinterBarcodeDetailLevel BarcodeDetailLevel { get; set; } = new BarcodePrinterBarcodeDetailLevel();

    public bool IncludePrinter { get; set; } = false;

    public class BarcodePrinterBarcodeDetailLevel
    {
        public bool IncludeDepositorCompany { get; set; } = false;
    }
}
