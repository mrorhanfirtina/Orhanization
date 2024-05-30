namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockPackTypes.Dtos.ResponseDtos;

public class StockPackTypesProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}