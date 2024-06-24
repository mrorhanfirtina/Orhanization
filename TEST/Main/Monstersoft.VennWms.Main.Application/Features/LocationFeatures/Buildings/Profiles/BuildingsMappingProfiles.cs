using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Profiles;

public class BuildingsMappingProfiles : Profile
{
    public BuildingsMappingProfiles()
    {

        //CreateBuildingCommand
        CreateMap<CreatedBuildingResponse, Building>().ReverseMap();

        //UpdateBuildingCommand
        CreateMap<UpdatedBuildingResponse, Building>().ReverseMap();

        //DeleteBuildingCommand
        CreateMap<DeletedBuildingResponse, Building>().ReverseMap();

        //GetByCodeBuildingQuery
        CreateMap<GetByCodeBuildingResponse, Building>().ReverseMap();

        //GetByIdBuildingQuery
        CreateMap<GetByIdBuildingResponse, Building>().ReverseMap();

        //GetListBuildingQuery
        CreateMap<GetListBuildingListItemDto, Building>().ReverseMap();
        CreateMap<Paginate<Building>, GetListResponse<GetListBuildingListItemDto>>().ReverseMap();

        //GetListByDynamicBuildingQuery
        CreateMap<GetListByDynamicBuildingListItemDto, Building>().ReverseMap();
        CreateMap<Paginate<Building>, GetListResponse<GetListByDynamicBuildingListItemDto>>().ReverseMap();

    }
}

