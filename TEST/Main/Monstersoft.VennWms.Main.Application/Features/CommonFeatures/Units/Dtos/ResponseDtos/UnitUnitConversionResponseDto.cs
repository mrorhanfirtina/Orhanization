namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.ResponseDtos;

public class UnitUnitConversionResponseDto
{
    public int ReferenceUnitId { get; set; }
    public int TargetUnitId { get; set; }
    public decimal ConversionRate { get; set; }
    public virtual UnitTargetUnitResponseDto? TargetUnit { get; set; }
}
