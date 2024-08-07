﻿using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Commands.Update;

public class UpdatedPoTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public PoTypeDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<PoTypePurchaseOrderResponseDto>? PurchaseOrders { get; set; }

}
