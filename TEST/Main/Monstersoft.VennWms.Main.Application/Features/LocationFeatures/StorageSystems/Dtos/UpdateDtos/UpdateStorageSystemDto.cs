namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.UpdateDtos;

public class UpdateStorageSystemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
}

