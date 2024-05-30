namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Dtos.ResponseDtos;

public class WorkTasksDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public WorkTasksCompanyResponseDto? Company { get; set; }
}