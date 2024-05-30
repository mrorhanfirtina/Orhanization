using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.CommonDynamicModels;

public class PriorityListDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public PriorityListsDetailLevel? DetailLevel { get; set; }
}

