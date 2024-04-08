using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Create;

public class CreatedTaskListResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<WorkTask> WorkTasks { get; set; }
}

