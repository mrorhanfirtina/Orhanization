using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

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

}

