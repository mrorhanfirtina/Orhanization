using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById.GetByIdDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;

public class GetByIdBarcodeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public string DepositorCode { get; set; }
    public virtual ICollection<GetByIdBarcodeBarcodeAreaDto> BarcodeAreas { get; set; }
    public virtual ICollection<GetByIdBarcodePrinterDto> Printers { get; set; }
}
