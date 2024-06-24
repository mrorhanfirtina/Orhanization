using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Constants;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Models.DynamicModels.DepositorDynamicModels;

public class CompanyDynamicModel()
{
    public DynamicQuery? DynamicQuery { get; set; }
    public CompaniesDetailLevel? DetailLevel { get; set; }
}

