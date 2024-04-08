namespace Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

public class CreateItemPackTypeDto
{
    public Guid ItemUnitId { get; set; }
    public decimal Length { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public int LenghtUnitId { get; set; }
    public decimal Volume { get; set; }
    public int VolumeUnitId { get; set; }
    public decimal DeadWeight { get; set; }
    public decimal NetWeight { get; set; }
    public int WeightUnitId { get; set; }
}

