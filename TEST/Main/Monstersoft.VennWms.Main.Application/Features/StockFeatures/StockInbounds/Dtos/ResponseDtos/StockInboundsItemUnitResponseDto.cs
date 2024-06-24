namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.ResponseDtos;

public class StockInboundsItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public StockInboundsUnitResponseDto? Unit { get; set; }
}