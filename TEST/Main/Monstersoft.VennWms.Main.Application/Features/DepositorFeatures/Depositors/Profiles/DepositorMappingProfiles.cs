using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Profiles;

public class DepositorMappingProfiles : Profile
{
    public DepositorMappingProfiles()
    {
        //CreateDepositorCommand
        CreateMap<CreatedDepositorResponse, Depositor>().ReverseMap();

        //UpdateDepositorCommand
        CreateMap<UpdatedDepositorResponse, Depositor>().ReverseMap();

        //DeleteDepositorCommand
        CreateMap<DeletedDepositorResponse, Depositor>().ReverseMap();

        //GetByCodeDepositorQuery
        CreateMap<GetByCodeDepositorResponse, Depositor>().ReverseMap();

        //GetByIdDepositorQuery
        CreateMap<GetByIdDepositorResponse, Depositor>().ReverseMap();

        //GetListDepositorQuery
        CreateMap<Depositor, GetListDepositorListItemDto>().ReverseMap();
        CreateMap<Paginate<Depositor>, GetListResponse<GetListDepositorListItemDto>>().ReverseMap();

        //GetListByDynamicDepositorQuery
        CreateMap<Depositor, GetListByDynamicDepositorListItemDto>().ReverseMap();
        CreateMap<Paginate<Depositor>, GetListResponse<GetListByDynamicDepositorListItemDto>>().ReverseMap();

    }
}
