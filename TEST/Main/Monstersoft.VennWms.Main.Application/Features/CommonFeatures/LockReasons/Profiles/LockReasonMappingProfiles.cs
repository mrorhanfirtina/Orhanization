using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LockReasons.Profiles;

public class LockReasonMappingProfiles : Profile
{
    public LockReasonMappingProfiles()
    {
        //CreateLockReasonCommand
        CreateMap<CreatedLockReasonResponse, LockReason>().ReverseMap();

        //UpdateLockReasonCommand
        CreateMap<UpdatedLockReasonResponse, LockReason>().ReverseMap();

        //DeleteLockReasonCommand
        CreateMap<DeletedLockReasonResponse, LockReason>().ReverseMap();

        //GetByCodeLockReasonQuery
        CreateMap<GetByCodeLockReasonResponse, LockReason>().ReverseMap();

        //GetByIdLockReasonQuery
        CreateMap<GetByIdLockReasonResponse, LockReason>().ReverseMap();

        //GetListLockReasonQuery
        CreateMap<LockReason, GetListLockReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<LockReason>, GetListResponse<GetListLockReasonListItemDto>>().ReverseMap();

        //GetListByDynamicLockReasonQuery
        CreateMap<LockReason, GetListByDynamicLockReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<LockReason>, GetListResponse<GetListByDynamicLockReasonListItemDto>>().ReverseMap();
    }
}
