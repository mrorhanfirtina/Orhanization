namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.ResponseDtos;

public class BarcodePrinterBarcodeResponseDto
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public BarcodePrinterDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
