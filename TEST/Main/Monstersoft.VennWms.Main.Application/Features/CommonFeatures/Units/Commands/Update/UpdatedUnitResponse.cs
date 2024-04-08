namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;

public class UpdatedUnitResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
