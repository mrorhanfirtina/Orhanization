using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Dtos.DtoProfiles;

public class ProductDtoMappingProfiles : Profile
{
    public ProductDtoMappingProfiles()
    {
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();

        CreateMap<AbcCategoryList, ProductAbcCategoryListResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, ProductAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<BarcodeSupplier, ProductBarcodeSupplierResponseDto>().ReverseMap();
        CreateMap<Company, ProductCompanyResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ProductConvertedItemUnitResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ProductDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, ProductDepositorResponseDto>().ReverseMap();
        CreateMap<ItemPackType, ProductItemPackTypeResponseDto>().ReverseMap();
        CreateMap<ItemUnitConversion, ProductItemUnitConversionResponseDto>().ReverseMap();
        CreateMap<ItemUnit, ProductItemUnitResponseDto>().ReverseMap();
        CreateMap<ProductAbcCategory, ProductProductAbcCategoryResponseDto>().ReverseMap();
        CreateMap<ProductAttribute, ProductProductAttributeResponseDto>().ReverseMap();
        CreateMap<ProductAttributeValue, ProductProductAttributeValueResponseDto>().ReverseMap();
        CreateMap<ProductBarcode, ProductProductBarcodeResponseDto>().ReverseMap();
        CreateMap<ProductCategoryList, ProductProductCategoryListResponseDto>().ReverseMap();
        CreateMap<ProductCategory, ProductProductCategoryResponseDto>().ReverseMap();
        CreateMap<ProductDepositor, ProductProductDepositorResponseDto>().ReverseMap();
        CreateMap<ProductStockAttribute, ProductProductStockAttributeResponseDto>().ReverseMap();
        CreateMap<StockAttribute, ProductStockAttributeResponseDto>().ReverseMap();
        CreateMap<Supplier, ProductSupplierResponseDto>().ReverseMap();
        CreateMap<Unit, ProductUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ProductVolumeUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ProductWeightUnitResponseDto>().ReverseMap();
        CreateMap<Unit, ProductLenghtUnitResponseDto>().ReverseMap();
    }
}
