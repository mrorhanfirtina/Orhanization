namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

public class CreateBranchSubDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid AddressId { get; set; }
    public CreateAddressSubDto? Address { get; set; }
}


