﻿namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Update;

public class UpdatedTransactionTypeResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsLogging { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}

