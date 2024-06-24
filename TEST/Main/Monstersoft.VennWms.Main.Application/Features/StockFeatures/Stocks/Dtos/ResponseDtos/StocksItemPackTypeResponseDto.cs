namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksItemPackTypeResponseDto
{
    public Guid Id { get; set; }
    public decimal? Length { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public int LenghtUnitId { get; set; }
    public decimal? Volume { get; set; }
    public int VolumeUnitId { get; set; }
    public decimal? DeadWeight { get; set; }
    public decimal? NetWeight { get; set; }
    public int WeightUnitId { get; set; }
    public StocksItemUnitResponseDto? ItemUnit { get; set; }
    public StocksUnitResponseDto? LenghtUnit { get; set; }
    public StocksUnitResponseDto? VolumeUnit { get; set; }
    public StocksUnitResponseDto? WeightUnit { get; set; }
}