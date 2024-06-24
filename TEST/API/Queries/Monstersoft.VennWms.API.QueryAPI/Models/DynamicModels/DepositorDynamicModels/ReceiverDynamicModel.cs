using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class ReceiverDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public ReceiversDetailLevel? DetailLevel { get; set; }
}

