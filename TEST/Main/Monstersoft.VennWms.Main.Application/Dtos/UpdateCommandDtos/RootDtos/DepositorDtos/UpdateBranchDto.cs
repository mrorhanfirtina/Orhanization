using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

public class UpdateBranchDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid AddressId { get; set; }
    public UpdateAddressSubDto Address { get; set; }
}

