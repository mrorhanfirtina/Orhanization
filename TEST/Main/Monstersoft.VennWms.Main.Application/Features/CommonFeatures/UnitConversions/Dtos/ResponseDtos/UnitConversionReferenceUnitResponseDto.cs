namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.ResponseDtos;

public class UnitConversionReferenceUnitResponseDto
{
    public string Code { get; set; }
    public string Description { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public UnitConversionDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
