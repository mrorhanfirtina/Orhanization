namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Delete;

public class DeletedLogStockResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

