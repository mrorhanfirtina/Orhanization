namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Constants;

public class StockInboundsDetailLevel
{
    public bool IncludeReceipt { get; set; } = false;
    public bool IncludeReturn { get; set; } = false;
    public bool IncludeStock { get; set; } = false;
    public bool IncludeItemUnit { get; set; } = false;
    public StockInboundsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new StockInboundsItemUnitSubDetailLevel();
    public class StockInboundsItemUnitSubDetailLevel
    {
        public bool IncludeUnit { get; set; } = false;
    }
}
