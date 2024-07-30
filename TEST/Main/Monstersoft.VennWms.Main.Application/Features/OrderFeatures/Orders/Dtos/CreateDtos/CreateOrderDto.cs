using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.CreateDtos;

public class CreateOrderDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid OrderTypeId { get; set; }
    public CreateCustomerSubDto? Customer { get; set; }
    public ICollection<CreateOrderAttributeValueSubDto>? OrderAttributeValues { get; set; }
    public ICollection<CreateOrderItemSubDto> OrderItems { get; set; }
    public ICollection<CreateOrderMemoSubDto>? OrderMemos { get; set; }
    public CreateOrderPrioritySubDto? OrderPriority { get; set; }
}

