using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;

public class GetByIdBranchResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid DistributorId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public BranchAddressResponseDto? Address { get; set; }
    public BranchDistributorResponseDto? Customer { get; set; }
    public BranchDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
