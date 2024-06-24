using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Profiles;

public class UnitMappingProfiles : Profile
{
    public UnitMappingProfiles()
    {
        //CreateUnitCommand
        CreateMap<CreatedUnitResponse, Unit>().ReverseMap();

        //UpdateUnitCommand
        CreateMap<UpdatedUnitResponse, Unit>().ReverseMap();

        //DeleteUnitCommand
        CreateMap<DeletedUnitResponse, Unit>().ReverseMap();

        //GetByCodeUnitQuery
        CreateMap<GetByCodeUnitResponse, Unit>().ReverseMap();

        //GetByIdUnitQuery
        CreateMap<GetByIdUnitResponse, Unit>().ReverseMap();

        //GetListUnitQuery
        CreateMap<Unit, GetListUnitListItemDto>().ReverseMap();
        CreateMap<Paginate<Unit>, GetListResponse<GetListUnitListItemDto>>().ReverseMap();

        //GetListByDynamicUnitQuery
        CreateMap<Unit, GetListByDynamicUnitListItemDto>().ReverseMap();
        CreateMap<Paginate<Unit>, GetListResponse<GetListByDynamicUnitListItemDto>>().ReverseMap();

    }
}
