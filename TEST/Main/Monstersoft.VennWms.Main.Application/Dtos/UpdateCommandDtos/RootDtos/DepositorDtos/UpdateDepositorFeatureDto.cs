﻿namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

public class UpdateDepositorFeatureDto
{
    public Guid Id { get; set; }
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
}