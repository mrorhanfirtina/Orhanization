using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Profiles;

public class ProductBarcodesMappingProfiles : Profile
{
    public ProductBarcodesMappingProfiles()
    {

        //CreateProductBarcodeCommand
        CreateMap<CreatedProductBarcodeResponse, ProductBarcode>().ReverseMap();

        //UpdateProductBarcodeCommand
        CreateMap<UpdatedProductBarcodeResponse, ProductBarcode>().ReverseMap();

        //DeleteProductBarcodeCommand
        CreateMap<DeletedProductBarcodeResponse, ProductBarcode>().ReverseMap();

        //GetByIdProductBarcodeQuery
        CreateMap<GetByIdProductBarcodeResponse, ProductBarcode>().ReverseMap();

        //GetListByDynamicProductBarcodeQuery
        CreateMap<GetListByDynamicProductBarcodeListItemDto, ProductBarcode>().ReverseMap();
        CreateMap<Paginate<ProductBarcode>, GetListResponse<GetListByDynamicProductBarcodeListItemDto>>().ReverseMap();

    }
}


