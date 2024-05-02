﻿namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Commands.Update;

public class UpdatedReceiptAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ReceiptAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

}