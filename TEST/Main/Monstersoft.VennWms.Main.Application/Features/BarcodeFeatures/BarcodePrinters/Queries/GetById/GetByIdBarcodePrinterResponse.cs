namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetById;

public class GetByIdBarcodePrinterResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public Guid PrinterId { get; set; }
}
