namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnAttributeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
}

