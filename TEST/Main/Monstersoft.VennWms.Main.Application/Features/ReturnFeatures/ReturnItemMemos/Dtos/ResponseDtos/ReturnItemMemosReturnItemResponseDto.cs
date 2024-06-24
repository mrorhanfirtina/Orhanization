namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.ResponseDtos;

public class ReturnItemMemosReturnItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ReturnItemMemosProductResponseDto? Product { get; set; }
    public ReturnItemMemosReturnResponseDto? Return { get; set; }
}