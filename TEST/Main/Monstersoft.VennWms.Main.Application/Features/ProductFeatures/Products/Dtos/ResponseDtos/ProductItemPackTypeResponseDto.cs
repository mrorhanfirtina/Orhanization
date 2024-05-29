namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;

public class ProductItemPackTypeResponseDto
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
    public ProductLenghtUnitResponseDto? LenghtUnit { get; set; }
    public ProductVolumeUnitResponseDto? VolumeUnit { get; set; }
    public ProductWeightUnitResponseDto? WeightUnit { get; set; }
}
