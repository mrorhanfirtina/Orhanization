using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Dtos.CreateDtos;

public class CreateReceiverDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CustomerId { get; set; }
    public CreateAddressSubDto Address { get; set; }
}

