using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Queries.GetById;

public class GetByIdReturnItemResponse
{
    public Guid Id { get; set; }
    public Guid ReturnId { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public decimal ExpectedQuantity { get; set; }
    public decimal ActualQuantity { get; set; }
    public int StatusId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public Return Return { get; set; }
    public ICollection<ReturnItemMemo> ReturnItemMemos { get; set; }
    public ICollection<ReturnItmStockAttrValue> ReturnItmStockAttrValues { get; set; }

}
