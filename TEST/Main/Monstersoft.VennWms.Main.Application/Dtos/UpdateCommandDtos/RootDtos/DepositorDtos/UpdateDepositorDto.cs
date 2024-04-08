using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

public class UpdateDepositorDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public UpdateDepositorFeatureSubDto DepositorFeature { get; set; }
}

