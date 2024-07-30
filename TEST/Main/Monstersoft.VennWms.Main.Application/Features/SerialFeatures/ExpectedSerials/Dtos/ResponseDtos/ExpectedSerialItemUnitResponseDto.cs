namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;

public class ExpectedSerialItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ExpectedSerialUnitResponseDto? Unit { get; set; }
    public ExpectedSerialProductResponseDto? Product { get; set; }
}
