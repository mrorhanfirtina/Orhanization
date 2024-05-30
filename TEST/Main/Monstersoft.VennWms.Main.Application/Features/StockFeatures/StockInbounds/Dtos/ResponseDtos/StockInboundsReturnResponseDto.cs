namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockInbounds.Dtos.ResponseDtos;

public class StockInboundsReturnResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}