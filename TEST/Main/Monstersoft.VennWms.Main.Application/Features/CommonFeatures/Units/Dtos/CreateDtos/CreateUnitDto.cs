using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.CreateDtos;

public class CreateUnitDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public ICollection<CreateUnitConversionSubDto> ReferenceUnitConversions { get; set; }
}

