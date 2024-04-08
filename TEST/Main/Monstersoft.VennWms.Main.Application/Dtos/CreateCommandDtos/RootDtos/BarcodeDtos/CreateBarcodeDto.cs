using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;

public class CreateBarcodeDto
{
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public ICollection<CreateBarcodeAreaSubDto>? BarcodeAreas { get; set; }
    public ICollection<CreateBarcodePrinterSubDto>? BarcodePrinters { get; set; }
}

