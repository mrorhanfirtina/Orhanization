namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateLogStockUnsuitReasonDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid FromReasonId { get; set; }
    public Guid ToReasonId { get; set; }

}

