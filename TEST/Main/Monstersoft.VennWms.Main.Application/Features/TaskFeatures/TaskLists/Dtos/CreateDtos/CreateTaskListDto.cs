namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.CreateDtos;

public class CreateTaskListDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<CreateWorkTaskSubDto> WorkTasks { get; set; }
}

