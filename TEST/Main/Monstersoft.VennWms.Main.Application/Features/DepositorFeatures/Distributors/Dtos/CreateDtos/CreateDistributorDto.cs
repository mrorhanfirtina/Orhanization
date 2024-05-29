using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.CreateDtos;

public class CreateDistributorDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public CreateAddressSubDto Address { get; set; }
}

