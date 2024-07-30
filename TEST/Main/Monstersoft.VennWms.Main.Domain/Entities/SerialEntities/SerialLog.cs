using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

public class SerialLog : Entity<Guid>
{
    public Guid TransactionLogId { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid ReceiptId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
    public virtual TransactionLog? TransactionLog { get; set; }
    public virtual TransactionType? TransactionType { get; set; }
    public virtual Depositor? Depositor { get; set; }
    public virtual DepositorCompany? DepositorCompany { get; set; }
    public virtual Receipt? Receipt { get; set; }

    public SerialLog()
    {
    }

    public SerialLog(Guid transactionLogId, int transactionTypeId, Guid depositorId, Guid depositorCompanyId, Guid receiptId, string serialNo, string sscc) : this()
    {
        TransactionLogId = transactionLogId;
        TransactionTypeId = transactionTypeId;
        DepositorId = depositorId;
        DepositorCompanyId = depositorCompanyId;
        ReceiptId = receiptId;
        SerialNo = serialNo;
        SSCC = sscc;
    }
}
