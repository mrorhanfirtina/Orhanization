using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Dtos.DtoProfiles;

public class ProductAbcCategoryDtoMappingProfiles : Profile
{
    public ProductAbcCategoryDtoMappingProfiles()
    {
        CreateMap<ProductAbcCategory, CreateProductAbcCategoryDto>().ReverseMap();
        CreateMap<ProductAbcCategory, CreateProductAbcCategorySubDto>().ReverseMap();
        CreateMap<ProductAbcCategory, UpdateProductAbcCategoryDto>().ReverseMap();
        CreateMap<ProductAbcCategory, UpdateProductAbcCategorySubDto>().ReverseMap();

        CreateMap<AbcCategoryList, ProductAbcCategoryAbcCategoryListResponseDto>().ReverseMap();
        CreateMap<Product, ProductAbcCategoryProductResponseDto>().ReverseMap();
    }
}
