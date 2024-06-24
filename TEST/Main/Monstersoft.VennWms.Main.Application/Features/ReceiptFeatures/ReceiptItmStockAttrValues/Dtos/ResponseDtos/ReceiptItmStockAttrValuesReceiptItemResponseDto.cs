namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItmStockAttrValues.Dtos.ResponseDtos;

public class ReceiptItmStockAttrValuesReceiptItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ReceiptId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ReceiptItmStockAttrValuesProductResponseDto? Product { get; set; }
    public ReceiptItmStockAttrValuesReceiptResponseDto? Receipt { get; set; }
}