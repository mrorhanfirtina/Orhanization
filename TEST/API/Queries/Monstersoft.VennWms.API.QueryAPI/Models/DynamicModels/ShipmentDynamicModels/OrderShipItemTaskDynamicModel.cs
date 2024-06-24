using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.ShipmentDynamicModels;

public class OrderShipItemTaskDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderShipItemTasksDetailLevel? DetailLevel { get; set; }
}

