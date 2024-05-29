﻿using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetListByDynamic;

public class GetListByDynamicOrderTypeListItemDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public int Counter { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderTypeDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<OrderTypeOrderResponseDto>? Orders { get; set; }

}
