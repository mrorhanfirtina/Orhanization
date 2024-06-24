using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.WorkTaskDynamicModels;

public class WorkTaskDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public WorkTasksDetailLevel? DetailLevel { get; set; }
}

