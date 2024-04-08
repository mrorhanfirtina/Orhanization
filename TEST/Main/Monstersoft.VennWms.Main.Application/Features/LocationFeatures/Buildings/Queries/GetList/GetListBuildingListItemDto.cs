namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetList;

public class GetListBuildingListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SiteId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Description { get; set; }
    public string Province { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AddressText { get; set; }
    public string ZipCode { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

