using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetListByDynamic;

public class GetListByDynamicUnitListItemDto
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public UnitDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public ICollection<UnitUnitConversionResponseDto>? ReferenceUnitConversions { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
