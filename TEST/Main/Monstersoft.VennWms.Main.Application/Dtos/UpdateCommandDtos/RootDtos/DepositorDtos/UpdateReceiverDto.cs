using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

public class UpdateReceiverDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public UpdateAddressSubDto Address { get; set; }
}

