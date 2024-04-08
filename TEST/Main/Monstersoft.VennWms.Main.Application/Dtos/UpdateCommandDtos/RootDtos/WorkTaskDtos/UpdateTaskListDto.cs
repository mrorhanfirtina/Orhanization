using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.WorkTaskDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.WorkTaskDtos;

public class UpdateTaskListDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public ICollection<UpdateWorkTaskSubDto> WorkTasks { get; set; }
}

