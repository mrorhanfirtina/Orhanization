using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.DtoProfiles;

public class PickingTypeDtoMappingProfiles : Profile
{
    public PickingTypeDtoMappingProfiles()
    {
        CreateMap<PickingType, CreatePickingTypeDto>().ReverseMap();
        CreateMap<PickingType, UpdatePickingTypeDto>().ReverseMap();
    }
}
