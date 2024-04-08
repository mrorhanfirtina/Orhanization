using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Profiles;

public class BranchMappingProfiles : Profile
{
    public BranchMappingProfiles()
    {
        //CreateBranchCommand
        CreateMap<CreatedBranchResponse, Branch>().ReverseMap();

        //UpdateBranchCommand
        CreateMap<UpdatedBranchResponse, Branch>().ReverseMap();

        //DeleteBranchCommand
        CreateMap<DeletedBranchResponse, Branch>().ReverseMap();

        //GetByCodeBranchQuery
        CreateMap<GetByCodeBranchResponse, Branch>().ReverseMap();

        //GetByIdBranchQuery
        CreateMap<GetByIdBranchResponse, Branch>().ReverseMap();

        //GetListBranchQuery
        CreateMap<Branch, GetListBranchListItemDto>().ReverseMap();
        CreateMap<Paginate<Branch>, GetListResponse<GetListBranchListItemDto>>().ReverseMap();

        //GetListByDynamicBranchQuery
        CreateMap<Branch, GetListByDynamicBranchListItemDto>().ReverseMap();
        CreateMap<Paginate<Branch>, GetListResponse<GetListByDynamicBranchListItemDto>>().ReverseMap();

    }
}
