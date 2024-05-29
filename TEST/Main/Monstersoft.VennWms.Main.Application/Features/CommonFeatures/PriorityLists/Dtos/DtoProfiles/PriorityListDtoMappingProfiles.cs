using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.DtoProfiles;

public class PriorityListDtoMappingProfiles : Profile
{
    public PriorityListDtoMappingProfiles()
    {
        CreateMap<PriorityList, CreatePriorityListDto>().ReverseMap();
        CreateMap<PriorityList, UpdatePriorityListDto>().ReverseMap();
    }
}
