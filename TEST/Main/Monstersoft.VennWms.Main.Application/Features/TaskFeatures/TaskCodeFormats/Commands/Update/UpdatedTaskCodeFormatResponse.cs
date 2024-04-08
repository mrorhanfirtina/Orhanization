namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Update;

public class UpdatedTaskCodeFormatResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string TaskFormat { get; set; }
    public int TaskCounter { get; set; }
    public string TaskListFormat { get; set; }
    public int TaskListCounter { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
}
