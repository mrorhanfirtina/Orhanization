namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Delete;

public class DeletedSerialLogResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
