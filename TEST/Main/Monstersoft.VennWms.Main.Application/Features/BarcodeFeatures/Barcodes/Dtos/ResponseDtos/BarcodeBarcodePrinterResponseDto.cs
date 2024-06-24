namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.ResponseDtos;

public class BarcodeBarcodePrinterResponseDto
{
    public Guid Id { get; set; }
    public BarcodePrinterResponseDto? Printer { get; set; }
}
