using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoProfiles;

public class ProductBarcodeDtoMappingProfiles : Profile
{
    public ProductBarcodeDtoMappingProfiles()
    {
        CreateMap<ProductBarcode, CreateProductBarcodeDto>().ReverseMap();
        CreateMap<ProductBarcode, CreateProductBarcodeSubDto>().ReverseMap();
        CreateMap<ProductBarcode, UpdateProductBarcodeDto>().ReverseMap();
        CreateMap<ProductBarcode, UpdateProductBarcodeSubDto>().ReverseMap();

        CreateMap<BarcodeSupplier, ProductBarcodeBarcodeSupplierResponseDto>().ReverseMap();
        CreateMap<Supplier, ProductBarcodeBarcodeSupplierSupplierResponseDto>().ReverseMap();
        CreateMap<Company, ProductBarcodeCompanyResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ProductBarcodeItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ProductBarcodeProductResponseDto>().ReverseMap();
    }
}
