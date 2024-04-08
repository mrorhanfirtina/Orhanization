namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

public class CreateCustomerSubDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public CreateAddressSubDto? Address { get; set; }

}

