using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;

public class CreatedSupplierResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public SupplierCompanyResponseDto? Company { get; set; }
    public SupplierAddressResponseDto? Address { get; set; }
    public SupplierDepositorCompanyResponseDto? DepositorCompany { get; set; }

}

