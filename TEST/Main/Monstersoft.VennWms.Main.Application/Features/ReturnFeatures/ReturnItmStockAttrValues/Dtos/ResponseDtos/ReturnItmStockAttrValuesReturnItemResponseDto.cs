namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.ResponseDtos;

public class ReturnItmStockAttrValuesReturnItemResponseDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ReturnItmStockAttrValuesProductResponseDto? Product { get; set; }
    public ReturnItmStockAttrValuesReturnResponseDto? Return { get; set; }
}