namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.ResponseDtos;

public class StockPackTypesDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public StockPackTypesCompanyResponseDto? Company { get; set; }
}