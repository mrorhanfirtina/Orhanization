namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.UpdateDtos;

public class UpdateTaskCodeFormatDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string TaskFormat { get; set; }
    public int TaskCounter { get; set; }
    public string TaskListFormat { get; set; }
    public int TaskListCounter { get; set; }
    public int TransactionTypeId { get; set; }
}
