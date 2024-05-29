using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.DtoProfiles;

public class ProductCategoryListDtoMappingProfiles : Profile
{
    public ProductCategoryListDtoMappingProfiles()
    {
        CreateMap<ProductCategoryList, CreateProductCategoryListDto>().ReverseMap();
        CreateMap<ProductCategoryList, CreateProductCategoryListSubDto>().ReverseMap();
        CreateMap<ProductCategoryList, UpdateProductCategoryListDto>().ReverseMap();
        CreateMap<ProductCategoryList, UpdateProductCategoryListSubDto>().ReverseMap();

        CreateMap<DepositorCompany, ProductCategoryListDepositorCompanyResponseDto>().ReverseMap();
    }
}
