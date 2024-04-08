using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;

public class CreateDepositorCompanyDto
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public CreateAddressSubDto Address { get; set; }
}

