using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ReserveReasons.Profiles;

public class ReserveReasonMappingProfiles : Profile
{
    public ReserveReasonMappingProfiles()
    {
        //CreateReserveReasonCommand
        CreateMap<CreatedReserveReasonResponse, ReserveReason>().ReverseMap();

        //UpdateReserveReasonCommand
        CreateMap<UpdatedReserveReasonResponse, ReserveReason>().ReverseMap();

        //DeleteReserveReasonCommand
        CreateMap<DeletedReserveReasonResponse, ReserveReason>().ReverseMap();

        //GetByCodeReserveReasonQuery
        CreateMap<GetByCodeReserveReasonResponse, ReserveReason>().ReverseMap();

        //GetByIdReserveReasonQuery
        CreateMap<GetByIdReserveReasonResponse, ReserveReason>().ReverseMap();

        //GetListReserveReasonQuery
        CreateMap<ReserveReason, GetListReserveReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<ReserveReason>, GetListResponse<GetListReserveReasonListItemDto>>().ReverseMap();

        //GetListByDynamicReserveReasonQuery
        CreateMap<ReserveReason, GetListByDynamicReserveReasonListItemDto>().ReverseMap();
        CreateMap<Paginate<ReserveReason>, GetListResponse<GetListByDynamicReserveReasonListItemDto>>().ReverseMap();

    }
}
