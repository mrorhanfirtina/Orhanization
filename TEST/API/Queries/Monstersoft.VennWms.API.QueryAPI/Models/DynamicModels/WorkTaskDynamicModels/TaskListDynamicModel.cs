using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.WorkTaskDynamicModels;

public class TaskListDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public TaskListsDetailLevel? DetailLevel { get; set; }
}

