using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributes.Dtos.DtoProfiles;

public class ReturnAttributeDtoMappingProfiles : Profile
{
    public ReturnAttributeDtoMappingProfiles()
    {
        CreateMap<ReturnAttribute, CreateReturnAttributeDto>().ReverseMap();
        CreateMap<ReturnAttribute, UpdateReturnAttributeDto>().ReverseMap();
    }
}
