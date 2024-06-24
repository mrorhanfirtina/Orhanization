﻿using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetById;

public class GetByIdLockReasonResponse
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public LockReasonDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
