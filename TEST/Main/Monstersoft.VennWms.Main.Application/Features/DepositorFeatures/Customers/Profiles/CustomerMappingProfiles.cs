using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Customers.Profiles;

public class CustomerMappingProfiles : Profile
{
    public CustomerMappingProfiles()
    {
        //CreateCustomerCommand
        CreateMap<CreatedCustomerResponse, Customer>().ReverseMap();

        //UpdateCustomerCommand
        CreateMap<UpdatedCustomerResponse, Customer>().ReverseMap();

        //DeleteCustomerCommand
        CreateMap<DeletedCustomerResponse, Customer>().ReverseMap();

        //GetByCodeCustomerQuery
        CreateMap<GetByCodeCustomerResponse, Customer>().ReverseMap();

        //GetByIdCustomerQuery
        CreateMap<GetByIdCustomerResponse, Customer>().ReverseMap();

        //GetListCustomerQuery
        CreateMap<Customer, GetListCustomerListItemDto>().ReverseMap();
        CreateMap<Paginate<Customer>, GetListResponse<GetListCustomerListItemDto>>().ReverseMap();

        //GetListByDynamicCustomerQuery
        CreateMap<Customer, GetListByDynamicCustomerListItemDto>().ReverseMap();
        CreateMap<Paginate<Customer>, GetListResponse<GetListByDynamicCustomerListItemDto>>().ReverseMap();

    }
}
