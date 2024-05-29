using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.UpdateDtos;

public class UpdateOrderSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public UpdateCustomerSubDto? Customer { get; set; }
    public ICollection<UpdateOrderAttributeValueSubDto> OrderAttributeValues { get; set; }
    public ICollection<UpdateOrderItemSubDto> OrderItems { get; set; }
    public ICollection<UpdateOrderMemoSubDto> OrderMemos { get; set; }
    public UpdateOrderPrioritySubDto? OrderPriority { get; set; }
}

