using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.LocationDynamicModels;

public class StorageSystemDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public StorageSystemsDetailLevel? DetailLevel { get; set; }
}

