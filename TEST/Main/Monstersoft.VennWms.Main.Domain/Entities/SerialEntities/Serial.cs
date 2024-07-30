using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

public class Serial : Entity<Guid>
{
    public Guid StockPackTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public virtual StockPackType? StockPackType { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual ReceiptItem? ReceiptItem { get; set; }
    public virtual ICollection<SerialHierarchy>? SerialHierarchies { get; set; }

    public Serial()
    {
        SerialHierarchies = new HashSet<SerialHierarchy>();
    }

    public Serial(Guid stockPackTypeId, Guid depositorId, Guid depositorCompanyId, Guid receiptId, Guid receiptItemId, string serialNo, string sscc) : this()
    {
        StockPackTypeId = stockPackTypeId;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
        ReceiptId = receiptId;
        ReceiptItemId = receiptItemId;
        SerialNo = serialNo;
        SSCC = sscc;
    }
}
