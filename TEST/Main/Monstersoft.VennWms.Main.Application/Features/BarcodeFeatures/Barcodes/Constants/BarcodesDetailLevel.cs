namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;

public class BarcodesDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeBarcodeAreas { get; set; } = false;
    public bool IncludeBarcodePrinters { get; set; } = false;
    public BarcodesBarcodePrinterSubDetailLevel BarcodePrinterDetailLevel { get; set; } = new BarcodesBarcodePrinterSubDetailLevel();

    public class BarcodesBarcodePrinterSubDetailLevel
    {
        public bool IncludePrinter { get; set; } = false;
    }
}
