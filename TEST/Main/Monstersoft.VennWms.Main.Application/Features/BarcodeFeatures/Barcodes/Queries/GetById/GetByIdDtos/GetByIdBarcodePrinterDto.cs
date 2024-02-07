using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById.GetByIdDtos;

public class GetByIdBarcodePrinterDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string PrinterAddress { get; set; }
}
