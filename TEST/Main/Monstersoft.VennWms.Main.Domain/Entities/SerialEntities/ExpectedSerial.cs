using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

public class ExpectedSerial : Entity<Guid>
{
    public Guid ItemUnitId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptItemId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public virtual ItemUnit? ItemUnit { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Receipt? Receipt { get; set; }
    public virtual ReceiptItem? ReceiptItem { get; set; }

    public ExpectedSerial()
    {
    }

    public ExpectedSerial(Guid itemUnitId, Guid depositorId, Guid depositorCompanyId, Guid receiptId, Guid receiptItemId, string serialNo, string sscc) : this()
    {
        ItemUnitId = itemUnitId;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
        ReceiptId = receiptId;
        ReceiptItemId = receiptItemId;
        SerialNo = serialNo;
        SSCC = sscc;
    }
}
