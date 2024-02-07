using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode.GetByCodeDtos;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;

public class GetByCodeBarcodeResponse
{
    public string Code { get; set; }
    public int Copy { get; set; }
    public string Query { get; set; }
    public string Text { get; set; }
    public string DepositorCode { get; set; }
    public virtual ICollection<GetByCodeBarcodeBarcodeAreaDto> BarcodeAreas { get; set; }
    public virtual ICollection<GetByCodeBarcodePrinterDto> Printers { get; set; }
}
