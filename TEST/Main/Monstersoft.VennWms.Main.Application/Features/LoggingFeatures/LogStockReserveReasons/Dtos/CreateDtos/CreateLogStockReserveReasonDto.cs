namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons;

public class CreateLogStockReserveReasonDto
{
    public Guid LogStockId { get; set; }
    public Guid FromReasonId { get; set; }
    public Guid ToReasonId { get; set; }

}

