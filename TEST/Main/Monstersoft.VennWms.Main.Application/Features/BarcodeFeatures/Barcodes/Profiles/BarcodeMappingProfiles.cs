using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Create.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Commands.Update.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode.GetByCodeDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById.GetByIdDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Profiles;

public class BarcodeMappingProfiles : Profile
{
    public BarcodeMappingProfiles()
    {
        //CreateBarcodeCommand
        CreateMap<Barcode, CreateBarcodeCommand>().ReverseMap();
        CreateMap<Barcode, CreatedBarcodeResponse>().ReverseMap();

        CreateMap<BarcodeArea, CreateBarcodeBarcodeAreaDto>().ReverseMap();
        CreateMap<Printer, CreateBarcodePrinterDto>().ReverseMap();

        //UpdateBarcodeCommand
        CreateMap<Barcode, UpdateBarcodeCommand>().ReverseMap();
        CreateMap<Barcode, UpdatedBarcodeResponse>().ReverseMap();

        CreateMap<BarcodeArea, UpdateBarcodeBarcodeAreaDto>().ReverseMap();
        CreateMap<Printer, UpdateBarcodePrinterDto>().ReverseMap();

        //DeletedBarcodeCommand
        CreateMap<Barcode, DeletedBarcodeResponse>().ReverseMap();

        //GetByCodeBarcodeQuery
        CreateMap<Barcode, GetByCodeBarcodeResponse>().ReverseMap();
        CreateMap<BarcodeArea, GetByCodeBarcodeBarcodeAreaDto>().ReverseMap();
        CreateMap<Printer, GetByCodeBarcodePrinterDto>().ReverseMap();

        //GetByIdBarcodeQuery
        CreateMap<Barcode, GetByIdBarcodeResponse>().ReverseMap();
        CreateMap<BarcodeArea, GetByIdBarcodeBarcodeAreaDto>().ReverseMap();
        CreateMap<Printer, GetByIdBarcodePrinterDto>().ReverseMap();

        //GetListBarcodeQuery
        CreateMap<Barcode, GetListBarcodeListItemDto>().ReverseMap();
        CreateMap<Paginate<Barcode>, GetListResponse<GetListBarcodeListItemDto>>().ReverseMap();

        //GetListByDynamicBarcodeQuery
        CreateMap<Barcode, GetListByDynamicBarcodeListItemDto>().ReverseMap();
        CreateMap<Paginate<Barcode>, GetListResponse<GetListByDynamicBarcodeListItemDto>>().ReverseMap();
    }
}
