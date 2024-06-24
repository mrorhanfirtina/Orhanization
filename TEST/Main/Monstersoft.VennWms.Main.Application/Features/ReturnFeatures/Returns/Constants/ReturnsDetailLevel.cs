namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Constants;

public class ReturnsDetailLevel
{
    public bool IncludeReturnMemo { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeStatus { get; set; } = false;
    public bool IncludeCustomer { get; set; } = false;
    public bool IncludeReturnType { get; set; } = false;
    public ReturnsCustomerSubDetailLevel CustomerDetailLevel { get; set; } = new ReturnsCustomerSubDetailLevel();
    public class ReturnsCustomerSubDetailLevel
    {
        public bool IncludeAddress { get; set; } = false;
        public bool IncludeCompany { get; set; } = false;
    }

    public bool IncludeReturnAttributeValue { get; set; } = false;
    public ReturnsReturnAttributeValueSubDetailLevel ReturnAttributeValueDetailLevel { get; set; } = new ReturnsReturnAttributeValueSubDetailLevel();
    public class ReturnsReturnAttributeValueSubDetailLevel
    {
        public bool IncludeReturnAttribute { get; set; } = false;

        public ReturnsReturnAttributeSubDetailLevel ReturnAttributeDetailLevel { get; set; } = new ReturnsReturnAttributeSubDetailLevel();
        public class ReturnsReturnAttributeSubDetailLevel
        {
            public bool IncludeAttributeInputType { get; set; } = false;
        }
    }
    public bool IncludeReturnItem { get; set; } = false;
    public ReturnsReturnItemSubDetailLevel ReturnItemDetailLevel { get; set; } = new ReturnsReturnItemSubDetailLevel();
    public class ReturnsReturnItemSubDetailLevel
    {
        public bool IncludeReturnItemMemo { get; set; } = false;
        public bool IncludeStatus { get; set; } = false;
        public bool IncludeProduct { get; set; } = false;
        public bool IncludeReturnItmStockAttrValue { get; set; } = false;
        public ReturnsReturnItmStockAttrValueSubDetailLevel ReturnItmStockAttrValueDetailLevel { get; set; } = new ReturnsReturnItmStockAttrValueSubDetailLevel();
        public class ReturnsReturnItmStockAttrValueSubDetailLevel
        {
            public bool IncludeStockAttribute { get; set; } = false;

            public ReturnsStockAttributeSubDetailLevel StockAttributeDetailLevel { get; set; } = new ReturnsStockAttributeSubDetailLevel();
            public class ReturnsStockAttributeSubDetailLevel
            {
                public bool IncludeAttributeInputType { get; set; } = false;
            }
        }

        public bool IncludeItemUnit { get; set; } = false;
        public ReturnsItemUnitSubDetailLevel ItemUnitDetailLevel { get; set; } = new ReturnsItemUnitSubDetailLevel();
        public class ReturnsItemUnitSubDetailLevel
        {
            public bool IncludeUnit { get; set; } = false;
        }
    }
}