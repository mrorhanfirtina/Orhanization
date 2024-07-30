namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;

public class SerialItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public SerialProductResponseDto? Product { get; set; }
    public SerialUnitResponseDto? Unit { get; set; }
}
