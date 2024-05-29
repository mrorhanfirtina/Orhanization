using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.UpdateDtos;

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

