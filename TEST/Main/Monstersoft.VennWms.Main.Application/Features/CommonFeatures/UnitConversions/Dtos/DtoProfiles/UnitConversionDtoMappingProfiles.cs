using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.DtoProfiles;

public class UnitConversionDtoMappingProfiles : Profile
{
    public UnitConversionDtoMappingProfiles()
    {
        CreateMap<UnitConversion, CreateUnitConversionDto>().ReverseMap();
        CreateMap<UnitConversion, CreateUnitConversionSubDto>().ReverseMap();
        CreateMap<UnitConversion, UpdateUnitConversionDto>().ReverseMap();
        CreateMap<UnitConversion, UpdateUnitConversionSubDto>().ReverseMap();

        CreateMap<DepositorCompany, UnitConversionDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Unit, UnitConversionReferenceUnitResponseDto>().ReverseMap();
        CreateMap<Unit, UnitConversionTargetUnitResponseDto>().ReverseMap();
    }
}
