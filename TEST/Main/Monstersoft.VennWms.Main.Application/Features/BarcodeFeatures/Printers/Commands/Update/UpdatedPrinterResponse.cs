namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;

public class UpdatedPrinterResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string PrinterAddress { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
