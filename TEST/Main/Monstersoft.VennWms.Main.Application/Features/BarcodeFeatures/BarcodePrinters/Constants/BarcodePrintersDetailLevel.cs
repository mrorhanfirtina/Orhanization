namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Constants;

public class BarcodePrintersDetailLevel
{
    public bool IncludeBarcode { get; set; } = false;
    public BarcodePrintersBarcodeSubDetailLevel BarcodeDetailLevel { get; set; } = new BarcodePrintersBarcodeSubDetailLevel();

    public bool IncludePrinter { get; set; } = false;

    public class BarcodePrintersBarcodeSubDetailLevel
    {
        public bool IncludeDepositorCompany { get; set; } = false;
    }
}
