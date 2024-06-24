﻿using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItems.Queries.GetListByDynamic;

public class GetListByDynamicReceiptItemListItemDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ReceiptItemsReceiptItemMemoResponseDto>? ReceiptItemMemos { get; set; }
    public ICollection<ReceiptItemsReceiptItmStockAttrValueResponseDto>? ReceiptItmStockAttrValues { get; set; }
    public ReceiptItemsProductResponseDto? Product { get; set; }
    public ReceiptItemsItemUnitResponseDto? ItemUnit { get; set; }
    public ReceiptItemsStatusResponseDto? Status { get; set; }
    public ReceiptItemsReceiptResponseDto? Receipt { get; set; }
}
