namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.UpdateDtos;

public class UpdateTaskListDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<UpdateWorkTaskSubDto> WorkTasks { get; set; }
}

