using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

public class BarcodePrinter : Entity<Guid>
{
    public Guid BarcodeId { get; set; }
    public Guid PrinterId { get; set; }
    public virtual Printer? Printer { get; set; }
    public virtual Barcode? Barcode { get; set; }

    public BarcodePrinter()
    {
    }

    public BarcodePrinter(Guid id, Guid barcodeId, Guid printerId)
    {
        Id = id;
        BarcodeId = barcodeId;
        PrinterId = printerId;
    }
}
