namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Commands.Delete;

public class DeletedItemUnitResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}
