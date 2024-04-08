using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ReturnDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReturnDtos;

public class CreateReturnItemDto
{
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<CreateReturnItemMemoSubDto> ReturnItemMemos { get; set; }
    public ICollection<CreateReturnItmStockAttrValueSubDto> ReturnItmStockAttrValues { get; set; }

}

