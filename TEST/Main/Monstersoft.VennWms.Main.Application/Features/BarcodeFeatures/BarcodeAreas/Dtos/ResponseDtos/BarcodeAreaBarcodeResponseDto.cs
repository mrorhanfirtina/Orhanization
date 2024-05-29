namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.ResponseDtos;

public class BarcodeAreaBarcodeResponseDto
{
    public string Code { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public BarcodeAreaDepositorCompanyResponseDto? DepositorCompany { get; set; }
}
