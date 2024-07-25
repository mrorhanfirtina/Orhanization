using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.DtoProfiles;

public class SerialDtoMappingProfiles : Profile
{
    public SerialDtoMappingProfiles()
    {
        CreateMap<Serial, CreateSerialDto>().ReverseMap();
        CreateMap<Serial, CreateSerialSubDto>().ReverseMap();
        CreateMap<Serial, UpdateSerialDto>().ReverseMap();
        CreateMap<Serial, UpdateSerialSubDto>().ReverseMap();

        CreateMap<Serial, SerialChildSerialResponseDto>().ReverseMap();
        CreateMap<SerialHierarchy, SerialSerialHierarchyResponseDto>().ReverseMap();
        CreateMap<ReceiptItem, SerialReceiptItemResponseDto>().ReverseMap();
        CreateMap<Receipt, SerialReceiptResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, SerialDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, SerialDepositorResponseDto>().ReverseMap();
        CreateMap<StockContainer, SerialStockContainerResponseDto>().ReverseMap();
        CreateMap<Location, SerialLocationResponseDto>().ReverseMap();
        CreateMap<Stock, SerialStockResponseDto>().ReverseMap();
        CreateMap<Product, SerialProductResponseDto>().ReverseMap();
        CreateMap<Domain.Entities.CommonEntities.Unit, SerialUnitResponseDto>().ReverseMap();
        CreateMap<ItemUnit, SerialItemUnitResponseDto>().ReverseMap();
        CreateMap<StockPackType, SerialStockPackTypeResponseDto>().ReverseMap();
    }
}
