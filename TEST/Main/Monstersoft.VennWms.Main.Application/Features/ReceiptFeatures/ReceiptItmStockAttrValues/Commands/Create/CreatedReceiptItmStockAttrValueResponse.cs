﻿namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Commands.Create;

public class CreatedReceiptItmStockAttrValueResponse
{
    public Guid Id { get; set; }
    public Guid ReceiptItemId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }

}

