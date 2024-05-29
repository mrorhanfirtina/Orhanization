using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetById;

public class GetByIdSupplierResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public SupplierCompanyResponseDto? Company { get; set; }
    public SupplierAddressResponseDto? Address { get; set; }
    public SupplierDepositorCompanyResponseDto? DepositorCompany { get; set; }
}

