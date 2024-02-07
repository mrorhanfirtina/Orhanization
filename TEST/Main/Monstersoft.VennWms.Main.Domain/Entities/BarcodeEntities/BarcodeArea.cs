using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class BarcodeArea : Entity<Guid>
{
    public Guid BarcodeId { get; set; }
    public string QueryField { get; set; }
    public string TextField { get; set; }
    [JsonIgnore]
    public virtual Barcode? Barcode { get; set; }

    public BarcodeArea()
    {
    }

    public BarcodeArea(Guid id,Guid barcodeId, string queryField, string textField):this()
    {
        Id = id;
        BarcodeId = barcodeId;
        QueryField = queryField;
        TextField = textField;
    }
}
