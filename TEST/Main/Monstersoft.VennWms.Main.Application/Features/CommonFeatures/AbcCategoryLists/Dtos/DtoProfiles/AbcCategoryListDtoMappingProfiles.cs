using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.DtoProfiles;

public class AbcCategoryListDtoMappingProfiles : Profile
{
    public AbcCategoryListDtoMappingProfiles()
    {
        CreateMap<AbcCategoryList, CreateAbcCategoryListDto>().ReverseMap();
        CreateMap<AbcCategoryList, UpdateAbcCategoryListDto>().ReverseMap();
        CreateMap<AbcCategoryList, AbcCategoryListSubResponseDto>().ReverseMap();
    }
}
