using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.CreateDtos;

public class CreatePoTypeDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public ICollection<CreatePurchaseOrderSubDto>? PurchaseOrders { get; set; }
}

