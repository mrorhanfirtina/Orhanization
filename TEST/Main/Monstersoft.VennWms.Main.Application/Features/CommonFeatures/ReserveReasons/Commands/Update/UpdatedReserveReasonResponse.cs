﻿namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;

public class UpdatedReserveReasonResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}