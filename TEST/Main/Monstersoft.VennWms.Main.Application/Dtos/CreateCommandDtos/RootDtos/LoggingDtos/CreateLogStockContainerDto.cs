﻿namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

public class CreateLogStockContainerDto
{
    public Guid LogStockId { get; set; }
    public Guid FromContainerId { get; set; }
    public Guid ToContainerId { get; set; }
    public string FromContainerSSCC { get; set; }
    public string ToContainerSSCC { get; set; }
    public int FromContainerTypeId { get; set; }
    public int ToContainerTypeId { get; set; }
}
