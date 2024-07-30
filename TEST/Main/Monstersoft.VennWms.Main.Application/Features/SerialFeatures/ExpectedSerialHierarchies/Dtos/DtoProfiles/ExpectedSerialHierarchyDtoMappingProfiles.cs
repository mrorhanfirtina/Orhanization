using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.DtoProfiles;

public class ExpectedSerialHierarchyDtoMappingProfiles : Profile
{
    public ExpectedSerialHierarchyDtoMappingProfiles()
    {
        CreateMap<ExpectedSerialHierarchy, CreateExpectedSerialHierarchyDto>().ReverseMap();
        CreateMap<ExpectedSerialHierarchy, CreateExpectedSerialHierarchySubDto>().ReverseMap();
        CreateMap<ExpectedSerialHierarchy, UpdateExpectedSerialHierarchyDto>().ReverseMap();
        CreateMap<ExpectedSerialHierarchy, UpdateExpectedSerialHierarchySubDto>().ReverseMap();

        CreateMap<Serial, ExpectedSerialHierarchyRootSerialResponseDto>().ReverseMap();
        CreateMap<Serial, ExpectedSerialHierarchyChildSerialResponseDto>().ReverseMap();
    }
}
