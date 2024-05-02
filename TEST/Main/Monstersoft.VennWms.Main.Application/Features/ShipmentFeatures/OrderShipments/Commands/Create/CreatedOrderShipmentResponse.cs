﻿using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipments.Commands.Create;

public class CreatedOrderShipmentResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid OrderId { get; set; }
    public Guid ShipmentId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime LastMoveDate { get; set; }
    public int ProgressStatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<OrderShipItem> OrderShipItems { get; set; }

}