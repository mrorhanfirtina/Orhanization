﻿using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Commands.Create;

public class CreatedShipmentTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<ShipmentTypesShipmentResponseDto>? Shipments { get; set; }
    public ShipmentTypesDepositorCompanyResponseDto DepositorCompany { get; set; }
}

