namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Delete;

public class DeletedAddressResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

