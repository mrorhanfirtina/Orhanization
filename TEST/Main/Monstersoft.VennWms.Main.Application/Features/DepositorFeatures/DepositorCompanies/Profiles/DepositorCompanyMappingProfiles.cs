using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Profiles;

public class DepositorCompanyMappingProfiles : Profile
{
    public DepositorCompanyMappingProfiles()
    {
        //CreateDepositorCompanyCommand
        CreateMap<CreatedDepositorCompanyResponse, DepositorCompany>().ReverseMap();

        //UpdateDepositorCompanyCommand
        CreateMap<UpdatedDepositorCompanyResponse, DepositorCompany>().ReverseMap();

        //DeleteDepositorCompanyCommand
        CreateMap<DeletedDepositorCompanyResponse, DepositorCompany>().ReverseMap();

        //GetByCodeDepositorCompanyQuery
        CreateMap<GetByCodeDepositorCompanyResponse, DepositorCompany>().ReverseMap();

        //GetByIdDepositorCompanyQuery
        CreateMap<GetByIdDepositorCompanyResponse, DepositorCompany>().ReverseMap();

        //GetListByDynamicDepositorCompanyQuery
        CreateMap<DepositorCompany, GetListByDynamicDepositorCompanyListItemDto>().ReverseMap();
        CreateMap<Paginate<DepositorCompany>, GetListResponse<GetListByDynamicDepositorCompanyListItemDto>>().ReverseMap();

    }
}
