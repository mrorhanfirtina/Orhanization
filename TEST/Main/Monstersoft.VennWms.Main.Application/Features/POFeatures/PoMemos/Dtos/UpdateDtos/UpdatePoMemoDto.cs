namespace Monstersoft.VennWms.Main.Application.Features.POFeatures;

public class UpdatePoMemoDto
{
    public Guid Id { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

