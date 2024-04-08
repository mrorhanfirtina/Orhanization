using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;

public class CreatedDepositorResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DepositorFeature DepositorFeature { get; set; }

}
