using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.CreateDtos;

public class CreateBarcodeDto
{
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public ICollection<CreateBarcodeAreaSubDto>? BarcodeAreas { get; set; }
    public ICollection<CreateBarcodePrinterSubDto>? BarcodePrinters { get; set; }
}

