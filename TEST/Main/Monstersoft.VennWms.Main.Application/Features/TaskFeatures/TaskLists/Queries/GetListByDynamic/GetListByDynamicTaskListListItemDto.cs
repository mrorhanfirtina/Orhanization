using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Queries.GetListByDynamic;

public class GetListByDynamicTaskListListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<WorkTask> WorkTasks { get; set; }

}

