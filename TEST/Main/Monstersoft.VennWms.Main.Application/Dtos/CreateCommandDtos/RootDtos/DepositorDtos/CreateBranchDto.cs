using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;

public class CreateBranchDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid AddressId { get; set; }
    public CreateAddressSubDto Address { get; set; }
}

