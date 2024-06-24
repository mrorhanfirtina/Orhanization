namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.CreateDtos;

public class CreateTransactionTypeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsLogging { get; set; }
    public bool IsTaskType { get; set; }
    public bool IsOperational { get; set; }
}

