using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Profiles;

public class BarcodeMappingProfiles : Profile
{
    public BarcodeMappingProfiles()
    {
        //CreateBarcodeCommand
        CreateMap<Barcode, CreatedBarcodeResponse>().ReverseMap();

        //UpdateBarcodeCommand
        CreateMap<Barcode, UpdatedBarcodeResponse>().ReverseMap();

        //DeletedBarcodeCommand
        CreateMap<Barcode, DeletedBarcodeResponse>().ReverseMap();

        //GetByCodeBarcodeQuery
        CreateMap<Barcode, GetByCodeBarcodeResponse>().ReverseMap();

        //GetByIdBarcodeQuery
        CreateMap<Barcode, GetByIdBarcodeResponse>().ReverseMap();

        //GetListBarcodeQuery
        CreateMap<Barcode, GetListBarcodeListItemDto>().ReverseMap();
        CreateMap<Paginate<Barcode>, GetListResponse<GetListBarcodeListItemDto>>().ReverseMap();

        //GetListByDynamicBarcodeQuery
        CreateMap<Barcode, GetListByDynamicBarcodeListItemDto>().ReverseMap();
        CreateMap<Paginate<Barcode>, GetListResponse<GetListByDynamicBarcodeListItemDto>>().ReverseMap();
    }
}
