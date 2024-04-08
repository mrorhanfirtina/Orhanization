namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ProductDtos;

public class CreateItemUnitSubDto
{
    public int UnitId { get; set; }
    public bool IsCustomerUnit { get; set; }
    public ICollection<CreateItemPackTypeSubDto> ItemPackTypes { get; set; }
}

