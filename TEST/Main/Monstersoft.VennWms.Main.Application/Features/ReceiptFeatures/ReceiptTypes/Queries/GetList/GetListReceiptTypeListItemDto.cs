﻿using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetList;

public class GetListReceiptTypeListItemDto
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
    public ReceiptTypesDepositorCompanyResponseDto? DepositorCompany { get; set; }
}

