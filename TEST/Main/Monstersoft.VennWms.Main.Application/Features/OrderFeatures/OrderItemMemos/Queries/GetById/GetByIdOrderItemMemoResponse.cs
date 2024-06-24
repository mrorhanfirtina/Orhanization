﻿using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderItemMemos.Queries.GetById;

public class GetByIdOrderItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid OrderItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderItemMemoOrderItemResponseDto? OrderItem { get; set; }
}

