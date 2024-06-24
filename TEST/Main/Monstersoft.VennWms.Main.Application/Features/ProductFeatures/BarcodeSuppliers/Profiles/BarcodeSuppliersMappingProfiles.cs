using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Profiles;

public class BarcodeSuppliersMappingProfiles : Profile
{
    public BarcodeSuppliersMappingProfiles()
    {

        //CreateBarcodeSupplierCommand
        CreateMap<CreatedBarcodeSupplierResponse, BarcodeSupplier>().ReverseMap();

        //UpdateBarcodeSupplierCommand
        CreateMap<UpdatedBarcodeSupplierResponse, BarcodeSupplier>().ReverseMap();

        //DeleteBarcodeSupplierCommand
        CreateMap<DeletedBarcodeSupplierResponse, BarcodeSupplier>().ReverseMap();

        //GetByIdBarcodeSupplierQuery
        CreateMap<GetByIdBarcodeSupplierResponse, BarcodeSupplier>().ReverseMap();

        //GetListBarcodeSupplierQuery
        CreateMap<GetListBarcodeSupplierListItemDto, BarcodeSupplier>().ReverseMap();
        CreateMap<Paginate<BarcodeSupplier>, GetListResponse<GetListBarcodeSupplierListItemDto>>().ReverseMap();

        //GetListByDynamicBarcodeSupplierQuery
        CreateMap<GetListByDynamicBarcodeSupplierListItemDto, BarcodeSupplier>().ReverseMap();
        CreateMap<Paginate<BarcodeSupplier>, GetListResponse<GetListByDynamicBarcodeSupplierListItemDto>>().ReverseMap();

    }
}
