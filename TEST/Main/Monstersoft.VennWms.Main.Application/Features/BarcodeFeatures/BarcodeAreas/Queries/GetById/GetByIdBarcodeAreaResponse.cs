using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetById;

public class GetByIdBarcodeAreaResponse
{
    public Guid Id { get; set; }
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
    public Barcode Barcode { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

