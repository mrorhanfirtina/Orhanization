using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.SerialDynamicModels;

public class ExpectedSerialHierarchyDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ExpectedSerialHierarchiesDetailLevel? DetailLevel { get; set; }
}
