namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;

public class OrderShipItemTasksDetailLevel
{
    public bool IncludeWorkTask { get; set; } = false;
    public bool IncludeOrderShipItem { get; set; } = false;
    public bool IncludeOrderShipItemStock { get; set; } = false;
    public OrderShipItemTasksOrderShipItemSubStockDetailLevel OrderShipItemStockDetailLevel { get; set; } = new OrderShipItemTasksOrderShipItemSubStockDetailLevel();
    public class OrderShipItemTasksOrderShipItemSubStockDetailLevel
    {
        public bool IncludeStock { get; set; } = false;
        public bool IncludeStockPackType { get; set; } = false;
    }
}
