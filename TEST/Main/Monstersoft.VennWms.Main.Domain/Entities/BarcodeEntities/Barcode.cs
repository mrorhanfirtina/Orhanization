using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class Barcode : Entity<Guid>
{
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public virtual DepositorCompany DepositorCompany { get; set; }
    public virtual ICollection<BarcodeArea> BarcodeAreas { get; set; }
    public virtual ICollection<BarcodePrinter> BarcodePrinters { get; set; }

    public Barcode()
    {
        BarcodeAreas = new HashSet<BarcodeArea>();
        BarcodePrinters = new HashSet<BarcodePrinter>();
    }

    public Barcode(Guid id, string code, int copy, string query, string text, Guid depositorCompanyId) : this()
    {
        Id = id;
        Code = code;
        Copy = copy;
        Query = query;
        Text = text;
        DepositorCompanyId = depositorCompanyId;
    }
}
