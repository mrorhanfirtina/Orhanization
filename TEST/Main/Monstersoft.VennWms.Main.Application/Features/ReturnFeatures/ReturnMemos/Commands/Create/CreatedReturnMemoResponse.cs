namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Commands.Create;

public class CreatedReturnMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }

}
