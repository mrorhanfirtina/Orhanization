namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.ResponseDtos;

public class ReturnsReturnItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<ReturnsReturnItemMemoResponseDto>? ReturnItemMemos { get; set; }
    public ICollection<ReturnsReturnItmStockAttrValueResponseDto>? ReturnItmStockAttrValues { get; set; }
    public ReturnsProductResponseDto? Product { get; set; }
    public ReturnsItemUnitResponseDto? ItemUnit { get; set; }
    public ReturnsStatusResponseDto? Status { get; set; }
}