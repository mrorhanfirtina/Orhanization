namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Delete;

public class DeletedSerialResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
