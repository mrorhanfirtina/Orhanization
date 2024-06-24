using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.DtoProfiles;

public class UnitDtoMappingProfiles : Profile
{
    public UnitDtoMappingProfiles()
    {
        CreateMap<Unit, CreateUnitDto>().ReverseMap();
        CreateMap<Unit, UpdateUnitDto>().ReverseMap();

        CreateMap<DepositorCompany, UpdateUnitDto>().ReverseMap();
        CreateMap<Unit, UnitTargetUnitResponseDto>().ReverseMap();
        CreateMap<UnitConversion, UnitUnitConversionResponseDto>().ReverseMap();
    }
}
