namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.ResponseDtos;

public class ItemPackTypeItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ItemPackTypeProductResponseDto? Product { get; set; }
    public ItemPackTypeUnitResponseDto? Unit { get; set; }
}
