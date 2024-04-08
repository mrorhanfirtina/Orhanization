namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnMemos.Queries.GetListByDynamic;

public class GetListByDynamicReturnMemoListItemDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
