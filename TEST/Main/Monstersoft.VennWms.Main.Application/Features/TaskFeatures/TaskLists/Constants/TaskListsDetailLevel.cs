namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;

public class TaskListsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeWorkTask { get; set; } = false;
    public bool IncludeDepositor { get; set; } = false;
    public TaskListsDepositorSubDetailLevel DepositorDetailLevel { get; set; } = new TaskListsDepositorSubDetailLevel();
    public class TaskListsDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
