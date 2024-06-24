using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Commands.Update;

public class UpdatedTaskListResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<TaskListsWorkTaskResponseDto>? WorkTasks { get; set; }
    public TaskListsDepositorResponseDto Depositor { get; set; }
    public TaskListsDepositorCompanyResponseDto DepositorCompany { get; set; }
}

