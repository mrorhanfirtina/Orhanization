using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;

public class UpdateDepositorSubDto
{
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public UpdateDepositorFeatureSubDto DepositorFeature { get; set; }
}

