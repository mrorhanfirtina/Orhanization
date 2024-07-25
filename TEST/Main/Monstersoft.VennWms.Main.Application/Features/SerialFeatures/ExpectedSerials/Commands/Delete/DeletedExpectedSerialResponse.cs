namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Delete;

public class DeletedExpectedSerialResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }
}
