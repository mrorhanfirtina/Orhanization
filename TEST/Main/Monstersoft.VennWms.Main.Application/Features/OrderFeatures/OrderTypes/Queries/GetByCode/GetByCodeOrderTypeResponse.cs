using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Queries.GetByCode;

public class GetByCodeOrderTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public int Counter { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderTypeDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<OrderTypeOrderResponseDto>? Orders { get; set; }

}
