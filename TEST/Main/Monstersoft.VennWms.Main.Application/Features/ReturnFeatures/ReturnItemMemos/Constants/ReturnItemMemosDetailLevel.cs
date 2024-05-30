namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Constants;

public class ReturnItemMemosDetailLevel
{
    public bool IncludeReturnItem { get; set; } = false;
    public ReturnItemMemosReturnItemSubDetailLevel ReturnItemDetailLevel { get; set; } = new ReturnItemMemosReturnItemSubDetailLevel();
    public class ReturnItemMemosReturnItemSubDetailLevel
    {
        public bool IncludeReturn { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
    }
}
