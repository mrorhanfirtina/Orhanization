using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.ProductDtos;

public class UpdateItemUnitDto
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public ICollection<UpdateItemPackTypeSubDto> ItemPackTypes { get; set; }

}

