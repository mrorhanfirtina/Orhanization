using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ItemPackTypes.Queries.GetById;

public class GetByIdItemPackTypeResponse
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
    public DateTime UpdatedDate { get; set; }
    public ItemPackTypeItemUnitResponseDto? ItemUnit { get; set; }
    public ItemPackTypeLenghtUnitResponseDto? LenghtUnit { get; set; }
    public ItemPackTypeVolumeUnitResponseDto? VolumeUnit { get; set; }
    public ItemPackTypeWeightUnitResponseDto? WeightUnit { get; set; }

}
