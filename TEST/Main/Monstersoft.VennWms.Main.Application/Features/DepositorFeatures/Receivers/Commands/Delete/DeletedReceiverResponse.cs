namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Delete;

public class DeletedReceiverResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
