using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;

public class UpdatedBarcodePrinterResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public Guid PrinterId { get; set; }
    public BarcodePrinterBarcodeResponseDto? Barcode { get; set; }
    public BarcodePrinterPrinterResponseDto? Printer { get; set; }
}
