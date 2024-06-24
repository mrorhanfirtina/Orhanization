using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Profiles;

public class PrintersMappingProfiles : Profile
{
    public PrintersMappingProfiles()
    {

        //CreatePrinterCommand
        CreateMap<CreatedPrinterResponse, Printer>().ReverseMap();

        //UpdatePrinterCommand
        CreateMap<UpdatedPrinterResponse, Printer>().ReverseMap();

        //DeletePrinterCommand
        CreateMap<DeletedPrinterResponse, Printer>().ReverseMap();

        //GetByCodePrinterQuery
        CreateMap<GetByCodePrinterResponse, Printer>().ReverseMap();

        //GetByIdPrinterQuery
        CreateMap<GetByIdPrinterResponse, Printer>().ReverseMap();

        //GetListPrinterQuery
        CreateMap<GetListPrinterListItemDto, Printer>().ReverseMap();
        CreateMap<Paginate<Printer>, GetListResponse<GetListPrinterListItemDto>>().ReverseMap();

        //GetListByDynamicPrinterQuery
        CreateMap<GetListByDynamicPrinterListItemDto, Printer>().ReverseMap();
        CreateMap<Paginate<Printer>, GetListResponse<GetListByDynamicPrinterListItemDto>>().ReverseMap();

    }
}
