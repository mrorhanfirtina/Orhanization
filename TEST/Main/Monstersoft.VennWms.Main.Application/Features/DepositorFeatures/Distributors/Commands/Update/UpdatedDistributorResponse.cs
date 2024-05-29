using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;

public class UpdatedDistributorResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DistributorCompanyResponseDto? Company { get; set; }
    public DistributorDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public DistributorAddressResponseDto? Address { get; set; }
    public ICollection<DistributorBranchResponseDto>? Branches { get; set; }

}

