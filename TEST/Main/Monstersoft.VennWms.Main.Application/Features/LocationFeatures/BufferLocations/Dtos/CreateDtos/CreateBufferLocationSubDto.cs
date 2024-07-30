namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.CreateDtos;

public class CreateBufferLocationSubDto
{
    public Guid LocationId { get; set; }
    public Guid BuffLocationId { get; set; }
    public bool IsBefore { get; set; }
}
