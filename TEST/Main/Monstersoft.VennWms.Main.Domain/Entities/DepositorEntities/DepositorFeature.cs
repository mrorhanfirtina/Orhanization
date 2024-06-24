using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

public class DepositorFeature : Entity<Guid>
{
    public Guid DepositorId { get; set; }
    public bool GenerateSsccLed { get; set; }
    public bool OrderModifyLed { get; set; }
    public bool ForbidNewReceiptLineLed { get; set; }
    public bool AllowDuplicateBarcodeLed { get; set; }
    public bool ForceTaskStockLed { get; set; }
    public bool ForbidTransferReservedLed { get; set; }
    public bool ChangeStockWithTaskLed { get; set; }
    public bool ManualReceiptCompletionLed { get; set; }
    public bool ManualReturnCompletionLed { get; set; }

    public DepositorFeature()
    {
    }

    public DepositorFeature(Guid id, Guid depositorId, bool generateSsccLed, bool orderModifyLed, bool forbidNewReceiptLineLed, bool allowDuplicateBarcodeLed, bool forceTaskStockLed, bool forbidTransferReservedLed, bool changeStockWithTaskLed, bool manualReceiptCompletionLed, bool manualReturnCompletionLed) : this()
    {
        Id = id;
        DepositorId = depositorId;
        GenerateSsccLed = generateSsccLed;
        OrderModifyLed = orderModifyLed;
        ForbidNewReceiptLineLed = forbidNewReceiptLineLed;
        AllowDuplicateBarcodeLed = allowDuplicateBarcodeLed;
        ForceTaskStockLed = forceTaskStockLed;
        ForbidTransferReservedLed = forbidTransferReservedLed;
        ChangeStockWithTaskLed = changeStockWithTaskLed;
        ManualReceiptCompletionLed = manualReceiptCompletionLed;
        ManualReturnCompletionLed = manualReturnCompletionLed;
    }
}
