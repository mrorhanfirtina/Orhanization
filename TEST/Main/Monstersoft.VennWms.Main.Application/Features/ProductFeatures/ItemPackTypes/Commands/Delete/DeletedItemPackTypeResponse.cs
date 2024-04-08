namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Delete;

public class DeletedItemPackTypeResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
