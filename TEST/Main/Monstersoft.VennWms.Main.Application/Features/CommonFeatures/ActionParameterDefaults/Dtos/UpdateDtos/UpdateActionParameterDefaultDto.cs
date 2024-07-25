namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class UpdateActionParameterDefaultDto
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Value { get; set; }
}
