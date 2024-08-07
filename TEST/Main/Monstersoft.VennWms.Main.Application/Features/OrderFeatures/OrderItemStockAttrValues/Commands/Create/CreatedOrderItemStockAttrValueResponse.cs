﻿using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemStockAttrValues.Commands.Create;

public class CreatedOrderItemStockAttrValueResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderItemStockAttrValueOrderItemResponseDto? OrderItem { get; set; }
    public OrderItemStockAttrValueStockAttributeResponseDto? StockAttribute { get; set; }

}
