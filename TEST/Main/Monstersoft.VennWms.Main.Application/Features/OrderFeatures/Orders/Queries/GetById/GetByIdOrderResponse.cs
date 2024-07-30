using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.Orders.Queries.GetById;

public class GetByIdOrderResponse
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
    public DateTime UpdatedDate { get; set; }
    public OrderCustomerResponseDto? Customer { get; set; }
    public OrderOrderPriorityResponseDto? OrderPriority { get; set; }
    public ICollection<OrderOrderShipmentResponseDto>? OrderShipments { get; set; }
    public OrderOrderTypeResponseDto? OrderType { get; set; }
    public ICollection<OrderOrderAttributeValueResponseDto>? OrderAttributeValues { get; set; }
    public ICollection<OrderOrderItemResponseDto>? OrderItems { get; set; }
    public ICollection<OrderOrderMemoResponseDto>? OrderMemos { get; set; }
    public OrderDepositorResponseDto? Depositor { get; set; }
    public OrderDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public OrderReceiverResponseDto? Receiver { get; set; }
    public OrderStatusResponseDto? Status { get; set; }

}
