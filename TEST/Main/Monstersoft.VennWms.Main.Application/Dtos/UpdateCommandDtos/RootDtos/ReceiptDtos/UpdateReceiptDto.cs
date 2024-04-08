﻿using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.PurchaseOrderDtos;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReceiptDtos;

public class UpdateReceiptDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime ExpectedDate { get; set; }
    public DateTime ReceiveDate { get; set; }
    public Guid PurchaseOrderId { get; set; }
    public Guid ReceiptTypeId { get; set; }
    public int StatusId { get; set; }
    public UpdatePurchaseOrderSubDto? PurchaseOrder { get; set; }
    public ICollection<UpdateReceiptAttributeValueSubDto> ReceiptAttributeValues { get; set; }
    public ICollection<UpdateReceiptItemSubDto> ReceiptItems { get; set; }
    public ICollection<UpdateReceiptMemoSubDto> ReceiptMemos { get; set; }
}

