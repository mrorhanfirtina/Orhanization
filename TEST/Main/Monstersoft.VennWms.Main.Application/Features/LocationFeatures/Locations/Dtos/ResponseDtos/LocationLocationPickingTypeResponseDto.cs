namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Dtos.ResponseDtos;

public class LocationLocationPickingTypeResponseDto
{
    public Guid Id { get; set; }
    public int PickingTypeId { get; set; }
    public virtual LocationPickingTypeResponseDto? PickingType { get; set; }
}
