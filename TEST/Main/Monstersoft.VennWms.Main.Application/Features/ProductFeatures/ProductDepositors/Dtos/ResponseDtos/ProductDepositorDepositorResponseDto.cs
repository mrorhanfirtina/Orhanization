using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.ResponseDtos;

public class ProductDepositorDepositorResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public Guid CompanyId { get; set; }
    public ProductDepositorCompanyResponseDto? Company { get; set; }
}
