namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.UpdateDtos;

public class UpdateReturnMemoDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }

}

