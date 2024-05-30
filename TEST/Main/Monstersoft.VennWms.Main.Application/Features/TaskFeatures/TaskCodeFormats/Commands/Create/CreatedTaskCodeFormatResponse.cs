using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Create;

public class CreatedTaskCodeFormatResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string TaskFormat { get; set; }
    public int TaskCounter { get; set; }
    public string TaskListFormat { get; set; }
    public int TaskListCounter { get; set; }
    public int TransactionTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public TaskCodeFormatsTransactionTypeResponseDto? TransactionType { get; set; }
    public TaskCodeFormatsDepositorCompanyResponseDto DepositorCompany { get; set; }
}
