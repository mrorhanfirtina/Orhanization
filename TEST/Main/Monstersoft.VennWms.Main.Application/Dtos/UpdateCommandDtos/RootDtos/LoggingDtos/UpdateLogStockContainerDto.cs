namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LoggingDtos;

public class UpdateLogStockContainerDto
{
    public Guid Id { get; set; }
    public Guid LogStockId { get; set; }
    public Guid FromContainerId { get; set; }
    public Guid ToContainerId { get; set; }
    public string FromContainerSSCC { get; set; }
    public string ToContainerSSCC { get; set; }
    public int FromContainerTypeId { get; set; }
    public int ToContainerTypeId { get; set; }
}

