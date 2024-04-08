namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetList;

public class GetListContainerUnitListItemDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
}
