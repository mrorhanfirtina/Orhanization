using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.OrderDtos;

public class UpdateOrderDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime ExpectedDate { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ReceiverId { get; set; }
    public Guid OrderTypeId { get; set; }
    public int StatusId { get; set; }
    public UpdateCustomerSubDto? Customer { get; set; }
    public ICollection<UpdateOrderAttributeValueSubDto> OrderAttributeValues { get; set; }
    public ICollection<UpdateOrderItemSubDto> OrderItems { get; set; }
    public ICollection<UpdateOrderMemoSubDto> OrderMemos { get; set; }
}

