using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodePrinters.Dtos.DtoProfiles;

public class BarcodePrinterDtoMappingProfiles : Profile
{
    public BarcodePrinterDtoMappingProfiles()
    {
        CreateMap<BarcodePrinter, CreateBarcodePrinterDto>().ReverseMap();
        CreateMap<BarcodePrinter, CreateBarcodePrinterSubDto>().ReverseMap();
        CreateMap<BarcodePrinter, UpdateBarcodePrinterDto>().ReverseMap();
        CreateMap<BarcodePrinter, UpdateBarcodePrinterSubDto>().ReverseMap();


        CreateMap<Barcode, BarcodePrinterBarcodeResponseDto>().ReverseMap();
        CreateMap<Printer, BarcodePrinterPrinterResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BarcodePrinterDepositorCompanyResponseDto>().ReverseMap();
    }
}
