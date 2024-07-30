using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures;

public class SerialHierarchyDtoMappingProfiles : Profile
{
    public SerialHierarchyDtoMappingProfiles()
    {
        CreateMap<SerialHierarchy, CreateSerialHierarchyDto>().ReverseMap();
        CreateMap<SerialHierarchy, CreateSerialHierarchySubDto>().ReverseMap();
        CreateMap<SerialHierarchy, UpdateSerialHierarchyDto>().ReverseMap();
        CreateMap<SerialHierarchy, UpdateSerialHierarchySubDto>().ReverseMap();

        CreateMap<SerialHiererchyRootSerialResponseDto, Serial>().ReverseMap();
        CreateMap<SerialHiererchyChildSerialResponseDto, Serial>().ReverseMap();
    }
}
