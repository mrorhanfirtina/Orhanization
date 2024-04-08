namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

public class CreateLogStockUnsuitReasonDto
{
    public Guid LogStockId { get; set; }
    public Guid FromReasonId { get; set; }
    public Guid ToReasonId { get; set; }

}

