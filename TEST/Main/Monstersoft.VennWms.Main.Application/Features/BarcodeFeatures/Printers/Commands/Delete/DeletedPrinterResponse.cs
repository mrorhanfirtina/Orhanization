namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Delete;

public class DeletedPrinterResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
