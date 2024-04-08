using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;

public class CreateDepositorDto
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public CreateDepositorFeatureSubDto DepositorFeature { get; set; }
}

