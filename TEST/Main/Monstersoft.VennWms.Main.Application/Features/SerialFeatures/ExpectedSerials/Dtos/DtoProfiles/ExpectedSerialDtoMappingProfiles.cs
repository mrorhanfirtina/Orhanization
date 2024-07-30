using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Unit = Monstersoft.VennWms.Main.Domain.Entities.CommonEntities.Unit;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.DtoProfiles;

public class ExpectedSerialDtoMappingProfiles : Profile
{
    public ExpectedSerialDtoMappingProfiles()
    {
        CreateMap<ExpectedSerial, CreateExpectedSerialDto>().ReverseMap();
        CreateMap<ExpectedSerial, CreateExpectedSerialSubDto>().ReverseMap();
        CreateMap<ExpectedSerial, UpdateExpectedSerialDto>().ReverseMap();
        CreateMap<ExpectedSerial, UpdateExpectedSerialSubDto>().ReverseMap();

        CreateMap<ItemUnit, ExpectedSerialItemUnitResponseDto>().ReverseMap();
        CreateMap<Product, ExpectedSerialProductResponseDto>().ReverseMap();
        CreateMap<Unit, ExpectedSerialUnitResponseDto>().ReverseMap();
        CreateMap<Depositor, ExpectedSerialDepositorResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ExpectedSerialDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Receipt, ExpectedSerialReceiptResponseDto>().ReverseMap();
        CreateMap<ReceiptItem, ExpectedSerialReceiptItemResponseDto>().ReverseMap();
    }
}
