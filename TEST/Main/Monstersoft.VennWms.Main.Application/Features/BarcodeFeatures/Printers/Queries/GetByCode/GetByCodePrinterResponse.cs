﻿using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetByCode;

public class GetByCodePrinterResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public PrinterDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public string PrinterAddress { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}
