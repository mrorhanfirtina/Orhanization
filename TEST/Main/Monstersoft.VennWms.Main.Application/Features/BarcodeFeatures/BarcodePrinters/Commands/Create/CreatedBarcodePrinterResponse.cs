namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;

public class CreatedBarcodePrinterResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public Guid PrinterId { get; set; }
}
