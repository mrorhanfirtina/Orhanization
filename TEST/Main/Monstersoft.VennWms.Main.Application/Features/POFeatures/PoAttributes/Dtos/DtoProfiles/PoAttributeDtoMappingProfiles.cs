using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.DtoProfiles;

public class PoAttributeDtoMappingProfiles : Profile
{
    public PoAttributeDtoMappingProfiles()
    {
        CreateMap<PoAttribute, CreatePoAttributeDto>().ReverseMap();
        CreateMap<PoAttribute, UpdatePoAttributeDto>().ReverseMap();

        CreateMap<AttributeInputType, PoAttributeAttributeInputTypeResponseDto>().ReverseMap();
        CreateMap<DepositorCompany, PoAttributeDepositorCompanyResponseDto>().ReverseMap();
    }
}
