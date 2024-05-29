using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.Returns.Dtos.DtoProfiles;

public class ReturnDtoMappingProfiles : Profile
{
    public ReturnDtoMappingProfiles()
    {
        CreateMap<Return, CreateReturnDto>().ReverseMap();
        CreateMap<Return, CreateReturnSubDto>().ReverseMap();
        CreateMap<Return, UpdateReturnDto>().ReverseMap();
        CreateMap<Return, UpdateReturnSubDto>().ReverseMap();
    }
}
