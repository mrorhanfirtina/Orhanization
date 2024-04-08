namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Commands.Create;

public class CreatedOrderItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }

}

