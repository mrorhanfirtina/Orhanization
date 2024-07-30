using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;

public class SerialHierarchyDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public SerialHierarchiesDetailLevel? DetailLevel { get; set; }
}
