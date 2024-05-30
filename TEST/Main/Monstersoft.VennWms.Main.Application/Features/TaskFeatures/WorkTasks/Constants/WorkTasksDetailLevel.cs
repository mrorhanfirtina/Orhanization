namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;

public class WorkTasksDetailLevel
{
    public bool IncludeFromLocation { get; set; } = false;
    public bool IncludeToLocation { get; set; } = false;
    public bool IncludeStatus { get; set; } = false;
    public bool IncludeTransactionType { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeOrderShipItemTask { get; set; } = false;
    public TasksDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new TasksDepositorSubDetailLevel();
    public class TasksDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
    public bool IncludeStock { get; set; } = false;
    public TasksStockSubDetailLevel StockDetailLevel { get; set; } = new TasksStockSubDetailLevel();
    public class TasksStockSubDetailLevel
    {
        public bool IncludeProduct { get; set; } = false;
    }
}
