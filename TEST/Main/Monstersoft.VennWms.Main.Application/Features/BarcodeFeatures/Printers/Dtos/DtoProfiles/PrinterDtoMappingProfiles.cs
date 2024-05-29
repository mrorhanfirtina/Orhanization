using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Dtos.DtoProfiles;

public class PrinterDtoMappingProfiles : Profile
{
    public PrinterDtoMappingProfiles()
    {
        CreateMap<Printer, CreatePrinterDto>().ReverseMap();
        CreateMap<Printer, CreatePrinterSubDto>().ReverseMap();
        CreateMap<Printer, UpdatePrinterDto>().ReverseMap();
        CreateMap<Printer, UpdatePrinterSubDto>().ReverseMap();

        CreateMap<DepositorCompany, PrinterDepositorCompanyResponseDto>().ReverseMap();
    }
}
