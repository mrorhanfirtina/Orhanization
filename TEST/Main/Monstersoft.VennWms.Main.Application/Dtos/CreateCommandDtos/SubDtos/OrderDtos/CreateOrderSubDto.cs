using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.OrderDtos;

public class CreateOrderSubDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public CreateCustomerSubDto? Customer { get; set; }
    public ICollection<CreateOrderAttributeValueSubDto> OrderAttributeValues { get; set; }
    public ICollection<CreateOrderItemSubDto> OrderItems { get; set; }
    public ICollection<CreateOrderMemoSubDto> OrderMemos { get; set; }

}

