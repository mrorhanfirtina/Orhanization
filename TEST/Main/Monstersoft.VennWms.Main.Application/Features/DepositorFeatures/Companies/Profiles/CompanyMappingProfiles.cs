using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Profiles;

public class CompanyMappingProfiles : Profile
{
    public CompanyMappingProfiles()
    {
        //CreateCompanyCommand
        CreateMap<CreatedCompanyResponse, Company>().ReverseMap();

        //UpdateCompanyCommand
        CreateMap<UpdatedCompanyResponse, Company>().ReverseMap();

        //DeleteCompanyCommand
        CreateMap<DeletedCompanyResponse, Company>().ReverseMap();

        //GetByCodeCompanyQuery
        CreateMap<GetByCodeCompanyResponse, Company>().ReverseMap();

        //GetByIdCompanyQuery
        CreateMap<GetByIdCompanyResponse, Company>().ReverseMap();

        //GetListCompanyQuery
        CreateMap<Company, GetListCompanyListItemDto>().ReverseMap();
        CreateMap<Paginate<Company>, GetListResponse<GetListCompanyListItemDto>>().ReverseMap();

        //GetListByDynamicCompanyQuery
        CreateMap<Company, GetListByDynamicCompanyListItemDto>().ReverseMap();
        CreateMap<Paginate<Company>, GetListResponse<GetListByDynamicCompanyListItemDto>>().ReverseMap();

    }
}
