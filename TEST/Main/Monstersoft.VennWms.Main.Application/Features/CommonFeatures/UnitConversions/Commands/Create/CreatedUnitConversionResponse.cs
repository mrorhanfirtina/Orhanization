using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Create;

public class CreatedUnitConversionResponse
{
    public int Id { get; set; }
    public int ReferenceUnitId { get; set; }
    public int TargetUnitId { get; set; }
    public decimal ConversionRate { get; set; }
    public UnitConversionReferenceUnitResponseDto? ReferenceUnit { get; set; }
    public UnitConversionTargetUnitResponseDto? TargetUnit { get; set; }
    public DateTime CreatedDate { get; set; }
}
