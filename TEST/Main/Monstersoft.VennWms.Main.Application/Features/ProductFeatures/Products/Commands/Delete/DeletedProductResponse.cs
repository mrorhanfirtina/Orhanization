namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Delete;

public class DeletedProductResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
