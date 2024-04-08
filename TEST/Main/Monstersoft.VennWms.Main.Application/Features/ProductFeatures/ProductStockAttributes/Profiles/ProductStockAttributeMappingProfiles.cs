using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;





namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Profiles;

public class ProductStockAttributeMappingProfiles : Profile
{
    public ProductStockAttributeMappingProfiles()
    {
        //CreateProductStockAttributeCommand
        CreateMap<CreatedProductStockAttributeResponse, ProductStockAttribute>().ReverseMap();

        //UpdateProductStockAttributeCommand
        CreateMap<UpdatedProductStockAttributeResponse, ProductStockAttribute>().ReverseMap();

        //DeleteProductStockAttributeCommand
        CreateMap<DeletedProductStockAttributeResponse, ProductStockAttribute>().ReverseMap();

        //GetByIdProductStockAttributeQuery
        CreateMap<GetByIdProductStockAttributeResponse, ProductStockAttribute>().ReverseMap();

        //GetListByDynamicProductStockAttributeQuery
        CreateMap<ProductStockAttribute, GetListByDynamicProductStockAttributeListItemDto>().ReverseMap();
        CreateMap<Paginate<ProductStockAttribute>, GetListResponse<GetListByDynamicProductStockAttributeListItemDto>>().ReverseMap();
    }
}

