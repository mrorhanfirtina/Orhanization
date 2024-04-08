using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

public class CreateOrderDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid OrderTypeId { get; set; }
    public CreateCustomerSubDto? Customer { get; set; }
    public ICollection<CreateOrderAttributeValueSubDto> OrderAttributeValues { get; set; }
    public ICollection<CreateOrderItemSubDto> OrderItems { get; set; }
    public ICollection<CreateOrderMemoSubDto> OrderMemos { get; set; }
}

