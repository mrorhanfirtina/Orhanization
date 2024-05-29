using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Dtos.DtoProfiles;

public class LockReasonDtoMappingProfiles : Profile
{
    public LockReasonDtoMappingProfiles()
    {
        CreateMap<LockReason, CreateLockReasonDto>().ReverseMap();
        CreateMap<LockReason, UpdateLockReasonDto>().ReverseMap();

        CreateMap<DepositorCompany, LockReasonDepositorCompanyResponseDto>().ReverseMap();
    }
}
