namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Delete;

public class DeletedProductAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

