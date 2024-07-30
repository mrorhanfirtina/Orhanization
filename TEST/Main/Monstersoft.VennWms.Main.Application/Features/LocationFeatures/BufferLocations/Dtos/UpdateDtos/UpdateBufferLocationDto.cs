namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.UpdateDtos;

public class UpdateBufferLocationDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid BuffLocationId { get; set; }
    public bool IsBefore { get; set; }
}
