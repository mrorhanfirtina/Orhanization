namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.ResponseDtos;

public class BarcodeSupplierSupplierResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public BarcodeSupplierCompanyResponseDto? Company { get; set; }
}
