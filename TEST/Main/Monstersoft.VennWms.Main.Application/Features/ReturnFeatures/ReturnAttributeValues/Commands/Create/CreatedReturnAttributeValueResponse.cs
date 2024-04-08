namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Commands.Create;

public class CreatedReturnAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ReturnAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }

}

