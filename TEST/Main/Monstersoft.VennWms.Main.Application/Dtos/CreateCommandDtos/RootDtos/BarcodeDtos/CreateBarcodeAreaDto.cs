using Orhanization.Core.Application.Dtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;

public class CreateBarcodeAreaDto : IDto
{
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
}

