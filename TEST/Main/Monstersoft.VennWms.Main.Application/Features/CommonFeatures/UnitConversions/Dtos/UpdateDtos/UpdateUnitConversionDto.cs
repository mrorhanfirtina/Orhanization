namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.UpdateDtos;

public class UpdateUnitConversionDto
{
    public int Id { get; set; }
    public int ReferenceUnitId { get; set; }
    public int TargetUnitId { get; set; }
    public decimal ConversionRate { get; set; }
}
