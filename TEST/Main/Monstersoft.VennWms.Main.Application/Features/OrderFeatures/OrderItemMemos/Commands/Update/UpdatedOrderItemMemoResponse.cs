namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Update;

public class UpdatedOrderItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

