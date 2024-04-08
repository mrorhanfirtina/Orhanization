namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnAttributeValueDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ReturnAttributeId { get; set; }
    public string Value { get; set; }
}

