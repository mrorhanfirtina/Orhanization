using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;

public class UpdatedReceiverResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReceiverCustomerResponseDto? Customer { get; set; }
    public ReceiverAddressResponseDto? Address { get; set; }
    public ReceiverDepositorCompanyResponseDto? DepositorCompany { get; set; }

}
