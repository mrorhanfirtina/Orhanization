namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateLogStockReserveReasonDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid FromReasaonId { get; set; }
    public Guid ToReasaonId { get; set; }

}

