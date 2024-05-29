using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Dtos.UpdateDtos;

public class UpdateCompanyDto
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

