namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.ResponseDtos;

public class ReturnItemsItemUnitResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsConsumerUnit { get; set; }
    public ReturnItemsUnitResponseDto? Unit { get; set; }
}