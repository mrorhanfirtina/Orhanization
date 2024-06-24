using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Profiles;

public class ProductCategoryListMappingProfiles : Profile
{
    public ProductCategoryListMappingProfiles()
    {
        //CreateProductCategoryListCommand
        CreateMap<CreatedProductCategoryListResponse, ProductCategoryList>().ReverseMap();

        //UpdateProductCategoryListCommand
        CreateMap<UpdatedProductCategoryListResponse, ProductCategoryList>().ReverseMap();

        //DeleteProductCategoryListCommand
        CreateMap<DeletedProductCategoryListResponse, ProductCategoryList>().ReverseMap();

        //GetByIdProductCategoryListQuery
        CreateMap<GetByIdProductCategoryListResponse, ProductCategoryList>().ReverseMap();

        //GetListByDynamicProductCategoryListQuery
        CreateMap<ProductCategoryList, GetListByDynamicProductCategoryListListItemDto>().ReverseMap();
        CreateMap<Paginate<ProductCategoryList>, GetListResponse<GetListByDynamicProductCategoryListListItemDto>>().ReverseMap();

        //GetByCodeProductCategoryListQuery
        CreateMap<GetByCodeProductCategoryListResponse, ProductCategoryList>().ReverseMap();

        //GetListProductCategoryListQuery
        CreateMap<ProductCategoryList, GetListProductCategoryListListItemDto>().ReverseMap();
        CreateMap<Paginate<ProductCategoryList>, GetListResponse<GetListProductCategoryListListItemDto>>().ReverseMap();
    }
}


