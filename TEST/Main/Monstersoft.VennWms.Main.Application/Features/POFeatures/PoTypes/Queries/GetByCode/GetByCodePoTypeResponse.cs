using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetByCode;

public class GetByCodePoTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public int Counter { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<PurchaseOrder> PurchaseOrders { get; set; }

}
