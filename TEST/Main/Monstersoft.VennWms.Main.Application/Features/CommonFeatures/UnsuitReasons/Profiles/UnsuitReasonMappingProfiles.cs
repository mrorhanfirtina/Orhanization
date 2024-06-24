using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Profiles;

public class UnsuitReasonMappingProfiles : Profile
{
    public UnsuitReasonMappingProfiles()
    {
        //CreateUnsuitReasonCommand
        CreateMap<CreatedUnsuitReasonResponse, UnsuitReason>().ReverseMap();

        //UpdateUnsuitReasonCommand
        CreateMap<UpdatedUnsuitReasonResponse, UnsuitReason>().ReverseMap();

        //DeleteUnsuitReasonCommand
        CreateMap<DeletedUnsuitReasonResponse, UnsuitReason>().ReverseMap();

        //GetByCodeUnsuitReasonQuery
        CreateMap<GetByCodeUnsuitReasonResponse, UnsuitReason>().ReverseMap();

        //GetByIdUnsuitReasonQuery
        CreateMap<GetByIdUnsuitReasonResponse, UnsuitReason>().ReverseMap();

        //GetListUnsuitReasonQuery
        CreateMap<UnsuitReason, GetListUnsuitReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<UnsuitReason>, GetListResponse<GetListUnsuitReasonListItemDto>>().ReverseMap();

        //GetListByDynamicUnsuitReasonQuery
        CreateMap<UnsuitReason, GetListByDynamicUnsuitReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<UnsuitReason>, GetListResponse<GetListByDynamicUnsuitReasonListItemDto>>().ReverseMap();
    }
}
