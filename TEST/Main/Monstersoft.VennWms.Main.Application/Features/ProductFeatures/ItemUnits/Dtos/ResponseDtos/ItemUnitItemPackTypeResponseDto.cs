namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemUnits.Dtos.ResponseDtos;

public class ItemUnitItemPackTypeResponseDto
{
    public Guid Id { get; set; }
    public decimal? Length { get; set; }
    public decimal? Width { get; set; }
    public decimal? Height { get; set; }
    public int LenghtUnitId { get; set; }
    public decimal? Volume { get; set; }
    public int VolumeUnitId { get; set; }
    public decimal? DeadWeight { get; set; }
    public decimal? NetWeight { get; set; }
    public int WeightUnitId { get; set; }
    public ItemUnitLenghtUnitResponseDto? LenghtUnit { get; set; }
    public ItemUnitVolumeUnitResponseDto? VolumeUnit { get; set; }
    public ItemUnitWeightUnitResponseDto? WeightUnit { get; set; }
}
