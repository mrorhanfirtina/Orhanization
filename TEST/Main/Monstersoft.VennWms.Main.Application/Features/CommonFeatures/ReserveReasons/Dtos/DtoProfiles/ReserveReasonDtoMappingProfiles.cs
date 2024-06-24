using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Dtos.DtoProfiles;

public class ReserveReasonDtoMappingProfiles : Profile
{
    public ReserveReasonDtoMappingProfiles()
    {
        CreateMap<ReserveReason, CreateReserveReasonDto>().ReverseMap();
        CreateMap<ReserveReason, UpdateReserveReasonDto>().ReverseMap();

        CreateMap<DepositorCompany, ReserveReasonDepositorCompanyResponseDto>().ReverseMap();
    }
}
