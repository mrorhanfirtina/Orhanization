using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class DepositorCompanyDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public DepositorCompaniesDetailLevel? DetailLevel { get; set; }
}

