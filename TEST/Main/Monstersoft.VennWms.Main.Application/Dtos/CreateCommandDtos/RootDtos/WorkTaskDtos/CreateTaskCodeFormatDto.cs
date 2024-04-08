namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.WorkTaskDtos;

public class CreateTaskCodeFormatDto
{
    public string Code { get; set; }
    public string TaskFormat { get; set; }
    public int TaskCounter { get; set; }
    public string TaskListFormat { get; set; }
    public int TaskListCounter { get; set; }
    public int TransactionTypeId { get; set; }
}
