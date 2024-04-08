namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

public class UpdateReturnItemSubDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<UpdateReturnItemMemoSubDto> ReturnItemMemos { get; set; }
    public ICollection<UpdateReturnItmStockAttrValueSubDto> ReturnItmStockAttrValues { get; set; }
}

