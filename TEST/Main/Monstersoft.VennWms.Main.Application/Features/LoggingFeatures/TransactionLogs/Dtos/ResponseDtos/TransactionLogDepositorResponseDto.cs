namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.ResponseDtos;

public class TransactionLogDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public TransactionLogCompanyResponseDto? Company { get; set; }
}
