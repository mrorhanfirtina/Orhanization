namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnitConversions.Commands.Delete;

public class DeletedItemUnitConversionResponse
{
    public Guid Id { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public string Message { get; set; }
    public bool IsSuccess { get; set; }

}

