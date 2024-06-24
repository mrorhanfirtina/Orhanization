using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.DtoProfiles;

public class ContainerUnitDtoMappingProfiles : Profile
{
    public ContainerUnitDtoMappingProfiles()
    {
        CreateMap<ContainerUnit, CreateContainerUnitDto>().ReverseMap();
        CreateMap<ContainerUnit, UpdateContainerUnitDto>().ReverseMap();

        CreateMap<DepositorCompany, ContainerUnitDepositorCompanyResponseDto>().ReverseMap();
        
    }
}
