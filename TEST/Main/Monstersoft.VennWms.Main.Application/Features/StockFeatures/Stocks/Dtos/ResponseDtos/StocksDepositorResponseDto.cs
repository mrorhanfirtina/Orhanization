namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.Stocks.Dtos.ResponseDtos;

public class StocksDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public StocksCompanyResponseDto? Company { get; set; }
}