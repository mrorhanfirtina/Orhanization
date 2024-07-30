namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.UpdateDtos;

public class UpdateActionParameterDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DefaultValue { get; set; }
    public int CategoryId { get; set; }
}
