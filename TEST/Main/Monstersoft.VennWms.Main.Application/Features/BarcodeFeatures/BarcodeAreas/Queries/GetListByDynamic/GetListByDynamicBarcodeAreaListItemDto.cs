namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetListByDynamic;

public class GetListByDynamicBarcodeAreaListItemDto
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
