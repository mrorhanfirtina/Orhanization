using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.WorkTaskDynamicModels;

public class TaskCodeFormatDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public TaskCodeFormatsDetailLevel? DetailLevel { get; set; }
}

