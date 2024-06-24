using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.UpdateDtos;

public class UpdateBarcodeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public ICollection<UpdateBarcodeAreaSubDto>? BarcodeAreas { get; set; }
    public ICollection<UpdateBarcodePrinterSubDto>? BarcodePrinters { get; set; }
}

