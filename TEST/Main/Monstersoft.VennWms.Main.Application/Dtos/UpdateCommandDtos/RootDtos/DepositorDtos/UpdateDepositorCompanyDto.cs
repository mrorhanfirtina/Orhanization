using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

public class UpdateDepositorCompanyDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public UpdateAddressSubDto Address { get; set; }
}

