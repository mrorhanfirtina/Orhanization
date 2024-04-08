namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;

public class UpdatedBarcodeAreaResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

