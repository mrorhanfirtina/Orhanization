using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetById;

public class GetByIdProductBarcodeResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid ItemUnitId { get; set; }
    public string BarcodeString { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public ICollection<ProductBarcodeBarcodeSupplierResponseDto>? BarcodeSuppliers { get; set; }
    public ProductBarcodeItemUnitResponseDto? ItemUnit { get; set; }
    public ProductBarcodeProductResponseDto? Product { get; set; }
}


