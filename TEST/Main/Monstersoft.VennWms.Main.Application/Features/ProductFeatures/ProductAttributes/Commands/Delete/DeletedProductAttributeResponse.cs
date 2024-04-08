namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Delete;

public class DeletedProductAttributeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
