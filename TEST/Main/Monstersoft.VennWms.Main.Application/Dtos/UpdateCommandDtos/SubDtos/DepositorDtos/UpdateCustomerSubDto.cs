namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

public class UpdateCustomerSubDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public UpdateAddressSubDto? Address { get; set; }

}

