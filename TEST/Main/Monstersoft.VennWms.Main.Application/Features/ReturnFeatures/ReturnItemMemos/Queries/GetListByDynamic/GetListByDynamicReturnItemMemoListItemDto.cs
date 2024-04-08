namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Queries.GetListByDynamic;

public class GetListByDynamicReturnItemMemoListItemDto
{
    public Guid Id { get; set; }
    public Guid ReturnItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

