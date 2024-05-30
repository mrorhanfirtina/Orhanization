namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.ResponseDtos;

public class StockPackTypesCuItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public StockPackTypesUnitResponseDto? Unit { get; set; }
}