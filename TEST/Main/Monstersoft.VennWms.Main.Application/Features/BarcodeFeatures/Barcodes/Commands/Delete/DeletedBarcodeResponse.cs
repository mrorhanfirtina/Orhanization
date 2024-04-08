namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;

public class DeletedBarcodeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
