using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;

public class UpdateBarcodeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public ICollection<UpdateBarcodeAreaSubDto> BarcodeAreas { get; set; }
    public ICollection<UpdateBarcodePrinterSubDto> BarcodePrinters { get; set; }
}

