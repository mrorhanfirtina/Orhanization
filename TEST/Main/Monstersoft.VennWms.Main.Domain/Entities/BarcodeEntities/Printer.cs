using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class Printer : Entity<Guid>
{
    public string Code { get; set; }
    public Guid BarcodeId { get; set; }
    public string PrinterAddress { get; set; }
    [JsonIgnore]
    public virtual Barcode? Barcode { get; set; }

    public Printer()
    {
    }

    public Printer(Guid id,string code, Guid barcodeId, string printerAddress): this()
    {
        Id = id;
        Code = code;
        BarcodeId = barcodeId;
        PrinterAddress = printerAddress;
    }
}
