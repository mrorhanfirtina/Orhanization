using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures;

public class UpdateBranchDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public UpdateAddressSubDto Address { get; set; }
}

