using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.DtoProfiles;

public class ProductCategoryDtoMappingProfiles : Profile
{
    public ProductCategoryDtoMappingProfiles()
    {
        CreateMap<ProductCategory, CreateProductCategoryDto>().ReverseMap();
        CreateMap<ProductCategory, CreateProductCategorySubDto>().ReverseMap();
        CreateMap<ProductCategory, UpdateProductCategoryDto>().ReverseMap();
        CreateMap<ProductCategory, UpdateProductCategorySubDto>().ReverseMap();

        CreateMap<ProductCategoryList, ProductCategoryProductCategoryListResponseDto>().ReverseMap();
        CreateMap<Product, ProductCategoryProductResponseDto>().ReverseMap();
    }
}
