namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Commands.Delete;

public class DeletedWorkTaskResponse
{
    public Guid Id { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

