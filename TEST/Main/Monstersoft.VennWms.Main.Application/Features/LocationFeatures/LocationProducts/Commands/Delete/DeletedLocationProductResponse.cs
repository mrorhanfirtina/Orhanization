namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Commands.Delete;

public class DeletedLocationProductResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
