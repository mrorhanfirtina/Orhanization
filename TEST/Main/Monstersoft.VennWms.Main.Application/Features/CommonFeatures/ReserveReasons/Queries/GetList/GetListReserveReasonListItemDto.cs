﻿using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetList;

public class GetListReserveReasonListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsBlocked { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ReserveReasonDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
