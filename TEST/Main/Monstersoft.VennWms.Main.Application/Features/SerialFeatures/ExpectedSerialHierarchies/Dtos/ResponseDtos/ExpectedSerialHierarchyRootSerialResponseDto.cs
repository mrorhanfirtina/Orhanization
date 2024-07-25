namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.ResponseDtos;

public class ExpectedSerialHierarchyRootSerialResponseDto
{
    public Guid Id { get; set; }
    public Guid StockPackTypeId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
}
