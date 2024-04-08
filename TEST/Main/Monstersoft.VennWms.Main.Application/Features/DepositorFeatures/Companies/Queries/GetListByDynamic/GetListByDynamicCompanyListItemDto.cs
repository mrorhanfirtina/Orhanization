using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetListByDynamic;

public class GetListByDynamicCompanyListItemDto
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
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Address Address { get; set; }

}
