namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.ResponseDtos;

public class StockContainersDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public StockContainersCompanyResponseDto? Company { get; set; }
}