namespace Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

public class UpdateItemUnitSubDto
{
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public ICollection<UpdateItemPackTypeSubDto> ItemPackTypes { get; set; }
}

