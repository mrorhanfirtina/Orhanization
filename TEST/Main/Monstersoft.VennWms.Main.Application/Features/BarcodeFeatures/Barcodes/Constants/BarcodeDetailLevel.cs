namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;

public class BarcodeDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeBarcodeAreas { get; set; } = false;
    public bool IncludeBarcodePrinters { get; set; } = false;
    public BarcodeBarcodePrinterDetailLevel BarcodePrinterDetailLevel { get; set; } = new BarcodeBarcodePrinterDetailLevel();

    public class BarcodeBarcodePrinterDetailLevel
    {
        public bool IncludePrinter { get; set; } = false;
    }
}
