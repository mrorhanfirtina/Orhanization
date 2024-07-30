namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.CreateDtos;

public class CreateActionParameterDefaultDto
{
    public int ActionParameterId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Value { get; set; }
}
