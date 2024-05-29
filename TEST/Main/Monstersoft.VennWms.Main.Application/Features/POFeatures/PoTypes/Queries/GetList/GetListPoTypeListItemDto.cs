using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Queries.GetList;

public class GetListPoTypeListItemDto
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
    public PoTypeDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<PoTypePurchaseOrderResponseDto>? PurchaseOrders { get; set; }

}
