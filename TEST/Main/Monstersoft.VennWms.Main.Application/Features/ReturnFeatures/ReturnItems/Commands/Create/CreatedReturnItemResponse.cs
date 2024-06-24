using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Commands.Create;

public class CreatedReturnItemResponse
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<ReturnItemsReturnItemMemoResponseDto>? ReturnItemMemos { get; set; }
    public ICollection<ReturnItemsReturnItmStockAttrValueResponseDto>? ReturnItmStockAttrValues { get; set; }
    public ReturnItemsProductResponseDto? Product { get; set; }
    public ReturnItemsItemUnitResponseDto? ItemUnit { get; set; }
    public ReturnItemsStatusResponseDto? Status { get; set; }
    public ReturnItemsReturnResponseDto? Return { get; set; }
}
