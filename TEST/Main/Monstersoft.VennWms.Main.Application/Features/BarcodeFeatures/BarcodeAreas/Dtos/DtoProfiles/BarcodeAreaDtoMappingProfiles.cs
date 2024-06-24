using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoProfiles;

public class BarcodeAreaDtoMappingProfiles : Profile
{
    public BarcodeAreaDtoMappingProfiles()
    {
        CreateMap<BarcodeArea, CreateBarcodeAreaDto>().ReverseMap();
        CreateMap<BarcodeArea, CreateBarcodeAreaSubDto>().ReverseMap();
        CreateMap<BarcodeArea, UpdateBarcodeAreaDto>().ReverseMap();
        CreateMap<BarcodeArea, UpdateBarcodeAreaSubDto>().ReverseMap();

        CreateMap<Barcode, BarcodeAreaBarcodeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BarcodeAreaDepositorCompanyResponseDto>().ReverseMap();
    }
}
