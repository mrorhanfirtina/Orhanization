using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;

public class CreatedBarcodeResponse
{ 
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual ICollection<BarcodeArea> BarcodeAreas { get; set; }
    public virtual ICollection<BarcodePrinter> BarcodePrinters { get; set; }
}
