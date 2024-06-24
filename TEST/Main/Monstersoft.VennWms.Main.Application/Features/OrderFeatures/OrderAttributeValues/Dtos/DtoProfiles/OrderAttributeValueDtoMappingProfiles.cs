using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoProfiles;

public class OrderAttributeValueDtoMappingProfiles : Profile
{
    public OrderAttributeValueDtoMappingProfiles()
    {
        CreateMap<OrderAttributeValue, CreateOrderAttributeValueDto>().ReverseMap();
        CreateMap<OrderAttributeValue, CreateOrderAttributeValueSubDto>().ReverseMap();
        CreateMap<OrderAttributeValue, UpdateOrderAttributeValueDto>().ReverseMap();
        CreateMap<OrderAttributeValue, UpdateOrderAttributeValueSubDto>().ReverseMap();

        CreateMap<AttributeInputType, OrderAttributeValueAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<OrderAttribute, OrderAttributeValueOrderAttributeResponseDto>().ReverseMap();
        CreateMap<Order, OrderAttributeValueOrderResponseDto>().ReverseMap();
    }
}
