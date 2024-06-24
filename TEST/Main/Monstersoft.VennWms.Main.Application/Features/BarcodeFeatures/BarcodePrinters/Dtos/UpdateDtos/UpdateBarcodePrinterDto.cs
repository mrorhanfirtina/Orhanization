namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures;

public class UpdateBarcodePrinterDto
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public Guid PrinterId { get; set; }
}
