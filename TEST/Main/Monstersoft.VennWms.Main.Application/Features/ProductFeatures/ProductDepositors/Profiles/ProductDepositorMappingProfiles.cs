using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Profiles;

public class ProductDepositorMappingProfiles : Profile
{
    public ProductDepositorMappingProfiles()
    {
        //CreateProductDepositorCommand
        CreateMap<CreatedProductDepositorResponse, ProductDepositor>().ReverseMap();

        //UpdateProductDepositorCommand
        CreateMap<UpdatedProductDepositorResponse, ProductDepositor>().ReverseMap();

        //DeleteProductDepositorCommand
        CreateMap<DeletedProductDepositorResponse, ProductDepositor>().ReverseMap();

        //GetByIdProductDepositorQuery
        CreateMap<GetByIdProductDepositorResponse, ProductDepositor>().ReverseMap();

        //GetListByDynamicProductDepositorQuery
        CreateMap<GetListByDynamicProductDepositorListItemDto, GetListByDynamicProductDepositorQuery>().ReverseMap();
        CreateMap<Paginate<ProductDepositor>, GetListResponse<GetListByDynamicProductDepositorListItemDto>>().ReverseMap();

    }
}


