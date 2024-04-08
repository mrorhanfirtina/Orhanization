using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetList;

public class GetListBranchListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CustomerId { get; set; }
    public Guid AddressId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Address Address { get; set; }

}
