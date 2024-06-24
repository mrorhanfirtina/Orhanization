using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Dtos.DtoProfiles;

public class UnsuitReasonDtoMappingProfiles : Profile
{
    public UnsuitReasonDtoMappingProfiles()
    {
        CreateMap<UnsuitReason, CreateUnsuitReasonDto>().ReverseMap();
        CreateMap<UnsuitReason, UpdateUnsuitReasonDto>().ReverseMap();

        CreateMap<DepositorCompany,UnsuitReasonDepositorCompanyResponseDto>().ReverseMap();
    }
}
