using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetListByDynamic;

public class GetListByDynamicBarcodeListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public Guid DepositorId { get; set; }
    public virtual ICollection<BarcodeArea> BarcodeAreas { get; set; }
    public virtual ICollection<Printer> Printers { get; set; }
}
