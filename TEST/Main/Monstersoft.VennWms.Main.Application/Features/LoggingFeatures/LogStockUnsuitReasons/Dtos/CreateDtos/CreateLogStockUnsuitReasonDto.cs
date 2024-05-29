namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStockUnsuitReasons.Dtos.CreateDtos;

public class CreateLogStockUnsuitReasonDto
{
    public Guid LogStockId { get; set; }
    public Guid FromReasonId { get; set; }
    public Guid ToReasonId { get; set; }

}

