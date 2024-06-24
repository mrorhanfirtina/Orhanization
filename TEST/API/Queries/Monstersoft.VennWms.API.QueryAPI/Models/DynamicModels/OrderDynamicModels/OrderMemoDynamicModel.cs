using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.OrderDynamicModels;

public class OrderMemoDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public OrderMemosDetailLevel? DetailLevel { get; set; }
}

