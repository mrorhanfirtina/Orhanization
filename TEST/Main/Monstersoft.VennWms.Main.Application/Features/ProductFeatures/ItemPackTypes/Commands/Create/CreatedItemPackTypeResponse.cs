namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Commands.Create;

public class CreatedItemPackTypeResponse
{
    public Guid Id { get; set; }
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
    public DateTime CreatedDate { get; set; }


}
