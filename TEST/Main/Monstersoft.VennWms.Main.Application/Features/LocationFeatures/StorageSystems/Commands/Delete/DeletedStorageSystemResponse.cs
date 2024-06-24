namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Delete;

public class DeletedStorageSystemResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

