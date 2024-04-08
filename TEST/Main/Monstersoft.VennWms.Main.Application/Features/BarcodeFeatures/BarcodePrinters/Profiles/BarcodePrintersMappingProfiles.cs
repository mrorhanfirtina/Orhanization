using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Profiles;

public class BarcodePrintersMappingProfiles : Profile
{
    public BarcodePrintersMappingProfiles()
    {
        //CreateBarcodePrinterCommand
        CreateMap<CreatedBarcodePrinterResponse, BarcodePrinter>().ReverseMap();

        //UpdateBarcodePrinterCommand
        CreateMap<UpdatedBarcodePrinterResponse, BarcodePrinter>().ReverseMap();

        //DeleteBarcodePrinterCommand
        CreateMap<DeletedBarcodePrinterResponse, BarcodePrinter>().ReverseMap();

        //GetByIdBarcodePrinterQuery
        CreateMap<GetByIdBarcodePrinterResponse, BarcodePrinter>().ReverseMap();

        //GetListByDynamicBarcodePrinterListItemDto
        CreateMap<GetListByDynamicBarcodePrinterListItemDto, BarcodePrinter>().ReverseMap();
        CreateMap<Paginate<BarcodePrinter>, GetListResponse<GetListByDynamicBarcodePrinterListItemDto>>().ReverseMap();

    }
}
