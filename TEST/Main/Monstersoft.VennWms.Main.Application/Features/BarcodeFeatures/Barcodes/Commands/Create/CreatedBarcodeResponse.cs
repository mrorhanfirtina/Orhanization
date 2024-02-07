using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;

public class CreatedBarcodeResponse
{ 
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public string DepositorCode { get; set; }
    public virtual ICollection<BarcodeArea> BarcodeAreas { get; set; }
    public virtual ICollection<Printer> Printers { get; set; }
}
