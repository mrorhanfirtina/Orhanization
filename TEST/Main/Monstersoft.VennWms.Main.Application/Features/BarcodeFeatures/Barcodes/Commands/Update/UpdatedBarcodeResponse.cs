using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;

public class UpdatedBarcodeResponse
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public BarcodeDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<BarcodeBarcodeAreaResponseDto>? BarcodeAreas { get; set; }
    public ICollection<BarcodeBarcodePrinterResponseDto>? BarcodePrinters { get; set; }
}
