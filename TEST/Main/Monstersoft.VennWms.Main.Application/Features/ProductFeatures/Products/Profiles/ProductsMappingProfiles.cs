
using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Profiles;

public class ProductsMappingProfiles : Profile
{
    public ProductsMappingProfiles()
    {

        //CreateProductCommand
        CreateMap<CreatedProductResponse, Product>().ReverseMap();

        //UpdateProductCommand
        CreateMap<UpdatedProductResponse, Product>().ReverseMap();

        //DeleteProductCommand
        CreateMap<DeletedProductResponse, Product>().ReverseMap();

        //GetByCodeProductQuery
        CreateMap<GetByCodeProductResponse, Product>().ReverseMap();

        //GetByIdProductQuery
        CreateMap<GetByIdProductResponse, Product>().ReverseMap();

        //GetListProductQuery
        CreateMap<GetListProductListItemDto, Product>().ReverseMap();
        CreateMap<Paginate<Product>, GetListResponse<GetListProductListItemDto>>().ReverseMap();

        //GetListByDynamicProductQuery
        CreateMap<GetListByDynamicProductListItemDto, Product>().ReverseMap();
        CreateMap<Paginate<Product>, GetListResponse<GetListByDynamicProductListItemDto>>().ReverseMap();

    }
}
