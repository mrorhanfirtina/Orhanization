using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;

public class CreatedDepositorCompanyResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string TaxOffice { get; set; }
    public string TaxNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string FaxNumber { get; set; }
    public Guid AddressId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DepositorCompanyAddressResponseDto? Address { get; set; }

}
