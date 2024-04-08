using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateItemUnitDto
{
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public ICollection<CreateItemPackTypeSubDto> ItemPackTypes { get; set; }

}

