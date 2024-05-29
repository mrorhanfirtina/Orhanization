using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorFeatures.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Dtos.CreateDtos;

public class CreateDepositorSubDto
{
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public CreateDepositorFeatureSubDto DepositorFeature { get; set; }
}

