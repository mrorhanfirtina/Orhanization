namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.ResponseDtos;

public class ReceiptsReceiptItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<ReceiptsReceiptItemMemoResponseDto>? ReceiptItemMemos { get; set; }
    public ICollection<ReceiptsReceiptItmStockAttrValueResponseDto>? ReceiptItmStockAttrValues { get; set; }
    public ReceiptsProductResponseDto? Product { get; set; }
    public ReceiptsItemUnitResponseDto? ItemUnit { get; set; }
    public ReceiptsStatusResponseDto? Status { get; set; }
}