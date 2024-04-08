using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetByDynamic;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Queries.GetList;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Profiles;

public class DistributorsMappingProfiles : Profile
{
    public DistributorsMappingProfiles()
    {

        //CreateDisturbitorCommand
        CreateMap<CreatedDistributorResponse, Distributor>().ReverseMap();

        //UpdateDisturbitorCommand
        CreateMap<UpdatedDistributorResponse, Distributor>().ReverseMap();

        //DeleteDisturbitorCommand
        CreateMap<DeletedDistributorResponse, Distributor>().ReverseMap();

        //GetByCodeDisturbitorQuery
        CreateMap<GetByCodeDistributorResponse, Distributor>().ReverseMap();

        //GetByIdDisturbitorQuery
        CreateMap<GetByIdDistributorResponse, Distributor>().ReverseMap();

        //GetListDisturbitorQuery
        CreateMap<GetListDistributorListItemDto, Distributor>().ReverseMap();
        CreateMap<Paginate<Distributor>, GetListResponse<GetListDistributorListItemDto>>().ReverseMap();

        //GetListByDynamicDisturbitorQuery
        CreateMap<GetListByDynamicDistributorListItemDto, Distributor>().ReverseMap();
        CreateMap<Paginate<Distributor>, GetListResponse<GetListByDynamicDistributorListItemDto>>().ReverseMap();

    }
}

