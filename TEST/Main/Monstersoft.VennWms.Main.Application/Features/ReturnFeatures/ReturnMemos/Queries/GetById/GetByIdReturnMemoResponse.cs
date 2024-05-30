using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetById;

public class GetByIdReturnMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReturnMemosReturnResponseDto? Return { get; set; }
}
