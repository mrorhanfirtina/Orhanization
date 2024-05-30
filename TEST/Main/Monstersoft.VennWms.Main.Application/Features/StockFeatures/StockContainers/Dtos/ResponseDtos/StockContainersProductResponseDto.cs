namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersProductResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public string? AlternativeCode { get; set; }
}