using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Dtos.DtoProfiles;

public class BarcodeDtoMappingProfiles : Profile
{
    public BarcodeDtoMappingProfiles()
    {
        CreateMap<Barcode, CreateBarcodeDto>().ReverseMap();
        CreateMap<Barcode, UpdateBarcodeDto>().ReverseMap();

        CreateMap<BarcodeArea, BarcodeBarcodeAreaResponseDto>().ReverseMap();
        CreateMap<BarcodePrinter, BarcodeBarcodePrinterResponseDto>().ReverseMap();
        CreateMap<Printer, BarcodePrinterResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BarcodeDepositorCompanyResponseDto>().ReverseMap();
    }
}
