using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;

public class CreatePoTypeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public ICollection<CreatePurchaseOrderSubDto>? PurchaseOrders { get; set; }
}

