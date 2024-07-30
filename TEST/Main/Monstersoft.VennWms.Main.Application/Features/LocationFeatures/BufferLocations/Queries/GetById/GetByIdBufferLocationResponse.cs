using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetById;

public class GetByIdBufferLocationResponse
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public Guid BuffLocationId { get; set; }
    public bool IsBefore { get; set; }
    public BufferLocationLocationResponseDto? Location { get; set; }
    public BufferLocationLocationResponseDto? BuffLocation { get; set; }
}
