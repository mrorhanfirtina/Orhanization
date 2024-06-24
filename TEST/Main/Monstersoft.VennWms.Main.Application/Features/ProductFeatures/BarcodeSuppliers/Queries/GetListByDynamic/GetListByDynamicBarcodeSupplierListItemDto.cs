using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetListByDynamic;

public class GetListByDynamicBarcodeSupplierListItemDto
{
    public Guid Id { get; set; }
    public Guid ProductBarcodeId { get; set; }
    public Guid SupplierId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public BarcodeSupplierDepositorCompanyResponseDto? DepositorCompany { get; set; }
    public BarcodeSupplierProductBarcodeResponseDto? ProductBarcode { get; set; }
    public BarcodeSupplierSupplierResponseDto? Supplier { get; set; }

}
