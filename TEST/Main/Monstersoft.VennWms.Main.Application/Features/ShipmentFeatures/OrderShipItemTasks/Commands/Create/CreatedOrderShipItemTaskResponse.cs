﻿using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItemTasks.Commands.Create;

public class CreatedOrderShipItemTaskResponse
{
    public Guid Id { get; set; }
    public Guid OrderShipItemId { get; set; }
    public Guid WorkTaskId { get; set; }
    public decimal Quantity { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderShipItem OrderShipItem { get; set; }
    public ICollection<OrderShipItemStock> OrderShipItemStocks { get; set; }

}