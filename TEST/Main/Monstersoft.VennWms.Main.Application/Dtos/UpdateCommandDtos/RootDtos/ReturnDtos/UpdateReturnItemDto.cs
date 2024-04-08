using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ReturnDtos;

public class UpdateReturnItemDto
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<UpdateReturnItemMemoSubDto> ReturnItemMemos { get; set; }
    public ICollection<UpdateReturnItmStockAttrValueSubDto> ReturnItmStockAttrValues { get; set; }

}

