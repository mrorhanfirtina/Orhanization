namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Create;

public class CreatedBarcodeAreaResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
    public DateTime CreatedDate { get; set; }

}

