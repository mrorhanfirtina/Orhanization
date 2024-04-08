using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.WorkTaskDtos;

public class CreateTaskListDto
{
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<CreateWorkTaskSubDto> WorkTasks { get; set; }
}

