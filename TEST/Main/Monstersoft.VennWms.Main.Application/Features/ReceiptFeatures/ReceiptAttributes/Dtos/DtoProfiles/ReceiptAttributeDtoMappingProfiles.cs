using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Dtos.DtoProfiles;

public class ReceiptAttributeDtoMappingProfiles : Profile
{
    public ReceiptAttributeDtoMappingProfiles()
    {
        CreateMap<ReceiptAttribute, CreateReceiptAttributeDto>().ReverseMap();
        CreateMap<ReceiptAttribute, UpdateReceiptAttributeDto>().ReverseMap();

        CreateMap<AttributeInputType, ReceiptAttributesAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, ReceiptAttributesDepositorCompanyResponseDto>().ReverseMap();
    }
}
