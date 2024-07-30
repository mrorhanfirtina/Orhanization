namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Delete;

public class DeletedBufferLocationResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
