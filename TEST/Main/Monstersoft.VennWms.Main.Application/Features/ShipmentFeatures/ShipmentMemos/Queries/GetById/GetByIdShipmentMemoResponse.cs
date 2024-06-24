﻿using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetById;

public class GetByIdShipmentMemoResponse
{
    public Guid Id { get; set; }
    public Guid ShipmentId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ShipmentMemosShipmentResponseDto? Shipment { get; set; }
}
