using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.DtoProfiles;

public class OrderAttributeDtoMappingProfiles : Profile
{
    public OrderAttributeDtoMappingProfiles()
    {
        CreateMap<OrderAttribute, CreateOrderAttributeDto>().ReverseMap();
        CreateMap<OrderAttribute, UpdateOrderAttributeDto>().ReverseMap();

        CreateMap<DepositorCompany, OrderAttributeDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<AttributeInputType, OrderAttributeAttributeInputTypeResponseDto>().ReverseMap();
    }
}
