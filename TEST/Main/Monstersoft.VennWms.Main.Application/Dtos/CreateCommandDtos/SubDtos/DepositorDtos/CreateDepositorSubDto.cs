using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

public class CreateDepositorSubDto
{
    public string Code { get; set; }
    public CreateDepositorFeatureSubDto DepositorFeature { get; set; }
}

