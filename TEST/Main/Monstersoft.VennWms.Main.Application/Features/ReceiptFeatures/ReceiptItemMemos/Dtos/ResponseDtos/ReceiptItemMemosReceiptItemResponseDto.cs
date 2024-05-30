namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.ResponseDtos;

public class ReceiptItemMemosReceiptItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ReceiptItemMemosProductResponseDto? Product { get; set; }
    public ReceiptItemMemosReceiptResponseDto? Receipt { get; set; }
}