using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.UpdateDtos;

public class UpdatePoTypeDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public ICollection<UpdatePurchaseOrderSubDto>? PurchaseOrders { get; set; }
}

