using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Profiles;

public class AddressesMappingProfiles : Profile
{
    public AddressesMappingProfiles()
    {

        //CreateAddressCommand
        CreateMap<CreatedAddressResponse, Address>().ReverseMap();

        //UpdateAddressCommand
        CreateMap<UpdatedAddressResponse, Address>().ReverseMap();

        //DeleteAddressCommand
        CreateMap<DeletedAddressResponse, Address>().ReverseMap();

        //GetByIdAddressQuery
        CreateMap<GetByIdAddressResponse, Address>().ReverseMap();

        //GetListByDynamicAddressQuery
        CreateMap<Address, GetListByDynamicAddressListItemDto>().ReverseMap();
        CreateMap<Paginate<Address>, GetListResponse<GetListByDynamicAddressListItemDto>>().ReverseMap();

    }
}

