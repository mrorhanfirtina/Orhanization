using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;

public class CreateReturnItemSubDto
{
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public ICollection<CreateReturnItemMemoSubDto> ReturnItemMemos { get; set; }
    public ICollection<CreateReturnItmStockAttrValueSubDto> ReturnItmStockAttrValues { get; set; }
}

