using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Dtos.DtoProfiles;

public class OrderTypeDtoMappingProfiles : Profile
{
    public OrderTypeDtoMappingProfiles()
    {
        CreateMap<OrderType, CreateOrderTypeDto>().ReverseMap();
        CreateMap<OrderType, UpdateOrderTypeDto>().ReverseMap();

        CreateMap<Customer, OrderTypeCustomerResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, OrderTypeDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Depositor, OrderTypeDepositorResponseDto>().ReverseMap();
        CreateMap<Order, OrderTypeOrderResponseDto>().ReverseMap();
        CreateMap<Receiver, OrderTypeReceiverResponseDto>().ReverseMap();
    }
}
