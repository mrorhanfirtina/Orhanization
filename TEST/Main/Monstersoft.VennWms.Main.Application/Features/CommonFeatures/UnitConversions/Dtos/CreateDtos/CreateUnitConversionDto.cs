namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.CreateDtos;

public class CreateUnitConversionDto
{
    public int ReferenceUnitId { get; set; }
    public int TargetUnitId { get; set; }
    public decimal ConversionRate { get; set; }
}
