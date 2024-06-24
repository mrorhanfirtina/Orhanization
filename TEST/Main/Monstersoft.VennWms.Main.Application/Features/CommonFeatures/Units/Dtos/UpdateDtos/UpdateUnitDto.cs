using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.UpdateDtos;

public class UpdateUnitDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public ICollection<UpdateUnitConversionSubDto> ReferenceUnitConversions { get; set; }
}

