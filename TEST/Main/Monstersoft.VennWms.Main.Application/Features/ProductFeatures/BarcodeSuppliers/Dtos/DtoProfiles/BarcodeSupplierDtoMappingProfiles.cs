using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoProfiles;

public class BarcodeSupplierDtoMappingProfiles : Profile
{
    public BarcodeSupplierDtoMappingProfiles()
    {
        CreateMap<BarcodeSupplier, CreateBarcodeSupplierDto>().ReverseMap();
        CreateMap<BarcodeSupplier, CreateBarcodeSupplierSubDto>().ReverseMap();
        CreateMap<BarcodeSupplier, UpdateBarcodeSupplierDto>().ReverseMap();
        CreateMap<BarcodeSupplier, UpdateBarcodeSupplierSubDto>().ReverseMap();

        CreateMap<Company, BarcodeSupplierCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, BarcodeSupplierDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<ProductBarcode, BarcodeSupplierProductBarcodeResponseDto>().ReverseMap();
        CreateMap<Supplier, BarcodeSupplierSupplierResponseDto>().ReverseMap();
    }
}
