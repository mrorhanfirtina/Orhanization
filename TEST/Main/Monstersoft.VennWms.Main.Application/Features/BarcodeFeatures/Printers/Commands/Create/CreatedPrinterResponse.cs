using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Create;

public class CreatedPrinterResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public PrinterDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public string PrinterAddress { get; set; }
    public DateTime CreatedDate { get; set; }

}
