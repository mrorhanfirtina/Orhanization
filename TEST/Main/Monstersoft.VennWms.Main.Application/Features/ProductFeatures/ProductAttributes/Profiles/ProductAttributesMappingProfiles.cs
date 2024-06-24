using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Profiles;

public class ProductAttributesMappingProfiles : Profile
{
    public ProductAttributesMappingProfiles()
    {

        //CreateProductAttributeCommand
        CreateMap<CreatedProductAttributeResponse, ProductAttribute>().ReverseMap();

        //UpdateProductAttributeCommand
        CreateMap<UpdatedProductAttributeResponse, ProductAttribute>().ReverseMap();

        //DeleteProductAttributeCommand
        CreateMap<DeletedProductAttributeResponse, ProductAttribute>().ReverseMap();

        //GetByCodeProductAttributeQuery
        CreateMap<GetByCodeProductAttributeResponse, ProductAttribute>().ReverseMap();

        //GetByIdProductAttributeQuery
        CreateMap<GetByIdProductAttributeResponse, ProductAttribute>().ReverseMap();

        //GetListProductAttributeQuery
        CreateMap<GetListProductAttributeListItemDto, ProductAttribute>().ReverseMap();
        CreateMap<Paginate<ProductAttribute>, GetListResponse<GetListProductAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicProductAttributeQuery
        CreateMap<GetListByDynamicProductAttributeListItemDto, ProductAttribute>().ReverseMap();
        CreateMap<Paginate<ProductAttribute>, GetListResponse<GetListByDynamicProductAttributeListItemDto>>().ReverseMap();

    }
}
