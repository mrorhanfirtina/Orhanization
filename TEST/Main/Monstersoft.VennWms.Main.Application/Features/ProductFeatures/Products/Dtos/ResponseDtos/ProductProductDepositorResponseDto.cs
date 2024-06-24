namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductProductDepositorResponseDto
{
    public Guid DepositorId { get; set; }
    public ProductDepositorResponseDto? Depositor { get; set; }
}
