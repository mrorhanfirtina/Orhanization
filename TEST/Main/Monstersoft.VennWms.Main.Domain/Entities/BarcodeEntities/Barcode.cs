using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class Barcode : Entity<Guid>
{
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<BarcodeArea> BarcodeAreas { get; set; }
    public virtual ICollection<Printer> Printers { get; set; }

    public Barcode()
    {
        BarcodeAreas = new HashSet<BarcodeArea>();
        Printers = new HashSet<Printer>();
    }

    public Barcode(Guid id, string code, int copy, string query, string text, Guid depositorId):this()
    {
        Id = id;
        Code = code;
        Copy = copy;
        Query = query;
        Text = text;
        DepositorId = depositorId;
    }
}
