namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockReserveReasons.Dtos.UpdateDtos;

public class UpdateLogStockReserveReasonDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid FromReasonId { get; set; }
    public Guid ToReasonId { get; set; }

}

