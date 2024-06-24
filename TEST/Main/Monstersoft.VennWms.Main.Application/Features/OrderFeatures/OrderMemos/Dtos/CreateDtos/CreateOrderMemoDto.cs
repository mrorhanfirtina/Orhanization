namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.CreateDtos;

public class CreateOrderMemoDto
{
    public Guid OrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
}

