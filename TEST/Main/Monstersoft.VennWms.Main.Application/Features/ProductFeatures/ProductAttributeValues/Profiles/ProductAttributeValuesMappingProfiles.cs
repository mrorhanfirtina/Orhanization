using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Profiles;

public class ProductAttributeValuesMappingProfiles : Profile
{
    public ProductAttributeValuesMappingProfiles()
    {

        //CreateProductAttributeValueCommand
        CreateMap<CreatedProductAttributeValueResponse, ProductAttributeValue>().ReverseMap();

        //UpdateProductAttributeValueCommand
        CreateMap<UpdatedProductAttributeValueResponse, ProductAttributeValue>().ReverseMap();

        //DeleteProductAttributeValueCommand
        CreateMap<DeletedProductAttributeValueResponse, ProductAttributeValue>().ReverseMap();

        //GetByIdProductAttributeValueQuery
        CreateMap<GetByIdProductAttributeValueResponse, ProductAttributeValue>().ReverseMap();

        //GetListByDynamicProductAttributeValueQuery
        CreateMap<GetListByDynamicProductAttributeValueListItemDto, ProductAttributeValue>().ReverseMap();
        CreateMap<Paginate<ProductAttributeValue>, GetListResponse<GetListByDynamicProductAttributeValueListItemDto>>().ReverseMap();

    }
}

