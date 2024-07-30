namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Constants;

public class ExpectedSerialsDetailLevel
{
    public bool IncludeItemUnit { get; set; } = false;
    public ExpectedSerialsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ExpectedSerialsItemUnitSubDetailLevel();
    public class ExpectedSerialsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
    public bool IncludeReceipt { get; set; } = false;
    public bool IncludeReceiptItem { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
}
