namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskLists.Dtos.ResponseDtos;

public class TaskListsDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public TaskListsCompanyResponseDto? Company { get; set; }
}