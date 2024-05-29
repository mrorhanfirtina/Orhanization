using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;

public class CreatedStorageSystemResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid BuildingId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public StorageSystemBuildingResponseDto? Building { get; set; }
    public StorageSystemDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<StorageSystemLocationResponseDto>? Locations { get; set; }
}

