namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;

public class SerialChildSerialResponseDto
{
    public Guid Id { get; set; }
    public Guid StockPackTypeId { get; set; }
    public string SerialNo { get; set; }
    public string SSCC { get; set; }
}