using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Commands.Create;

public class CreatedOrderResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ActualDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid OrderTypeId { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public Customer Customer { get; set; }
    public OrderType OrderType { get; set; }
    public ICollection<OrderAttributeValue> OrderAttributeValues { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
    public ICollection<OrderMemo> OrderMemos { get; set; }
}
