﻿namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Commands.Delete;

public class DeletedPoAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

