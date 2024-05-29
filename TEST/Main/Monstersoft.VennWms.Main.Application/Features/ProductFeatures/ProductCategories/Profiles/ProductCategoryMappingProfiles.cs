using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Profiles;

public class ProductCategoryMappingProfiles : Profile
{
    public ProductCategoryMappingProfiles()
    {
        //CreateProductCategoryCommand
        CreateMap<CreatedProductCategoryResponse, ProductCategory>().ReverseMap();

        //UpdateProductCategoryCommand
        CreateMap<UpdatedProductCategoryResponse, ProductCategory>().ReverseMap();

        //DeleteProductCategoryCommand
        CreateMap<DeletedProductCategoryResponse, ProductCategory>().ReverseMap();

        //GetByIdProductCategoryQuery
        CreateMap<GetByIdProductCategoryResponse, ProductCategory>().ReverseMap();

        //GetListByDynamicProductCategoryQuery
        CreateMap<ProductCategory, GetListByDynamicProductCategoryListItemDto>().ReverseMap();
        CreateMap<Paginate<ProductCategory>, GetListResponse<GetListByDynamicProductCategoryListItemDto>>().ReverseMap();

    }
}

