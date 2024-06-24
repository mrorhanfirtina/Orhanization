using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Queries.GetListByDynamic;

public class GetListByDynamicProductDepositorListItemDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid DepositorId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ProductDepositorDepositorResponseDto? Depositor { get; set; }
    public ProductDepositorProductResponseDto? Product { get; set; }
}


