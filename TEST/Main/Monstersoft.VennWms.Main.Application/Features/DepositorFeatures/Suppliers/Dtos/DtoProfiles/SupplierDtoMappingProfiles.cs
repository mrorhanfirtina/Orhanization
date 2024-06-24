using AutoMapper;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Dtos.DtoProfiles;

public class SupplierDtoMappingProfiles : Profile
{
    public SupplierDtoMappingProfiles()
    {
        CreateMap<Supplier, CreateSupplierDto>().ReverseMap();
        CreateMap<Supplier, CreateSupplierSubDto>().ReverseMap();
        CreateMap<Supplier, UpdateSupplierDto>().ReverseMap();
        CreateMap<Supplier, UpdateSupplierSubDto>().ReverseMap();

        CreateMap<Address, SupplierAddressResponseDto>().ReverseMap();
        CreateMap<Company, SupplierCompanyResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, SupplierDepositorCompanyResponseDto>().ReverseMap();
    }
}
