﻿namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.CreateDtos;

public class CreateLocationDepositorDto
{
    public Guid LocationId { get; set; }
    public Guid DepositorId { get; set; }
    public bool IsForbid { get; set; }
}
