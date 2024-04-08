using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Queries.GetById;

public class GetByIdItemUnitResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ItemPackType> ItemPackTypes { get; set; }

}
