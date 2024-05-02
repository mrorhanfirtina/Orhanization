﻿using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Commands.Create;

public class CreatedPurchaseOrderResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public Guid PoTypeId { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public Supplier Supplier { get; set; }
    public PoType PoType { get; set; }
    public ICollection<PoAttributeValue> PoAttributeValues { get; set; }
    public ICollection<PoMemo> PoMemo { get; set; }
    public ICollection<Receipt> Receipt { get; set; }

}