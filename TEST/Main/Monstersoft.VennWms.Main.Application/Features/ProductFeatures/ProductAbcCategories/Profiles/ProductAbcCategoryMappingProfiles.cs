using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Profiles;

public class ProductAbcCategoryMappingProfiles : Profile
{
    public ProductAbcCategoryMappingProfiles()
    {
        //CreateProductAbcCategoryCommand
        CreateMap<CreatedProductAbcCategoryResponse, ProductAbcCategory>().ReverseMap();

        //UpdateProductAbcCategoryCommand
        CreateMap<UpdatedProductAbcCategoryResponse, ProductAbcCategory>().ReverseMap();

        //DeleteProductAbcCategoryCommand
        CreateMap<DeletedProductAbcCategoryResponse, ProductAbcCategory>().ReverseMap();

        //GetByIdProductAbcCategoryQuery
        CreateMap<GetByIdProductAbcCategoryResponse, ProductAbcCategory>().ReverseMap();

        //GetListByDynamicProductAbcCategoryQuery
        CreateMap<ProductAbcCategory, GetListByDynamicProductAbcCategoryListItemDto>().ReverseMap();
        CreateMap<Paginate<ProductAbcCategory>, GetListResponse<GetListByDynamicProductAbcCategoryListItemDto>>().ReverseMap();

    }
}


