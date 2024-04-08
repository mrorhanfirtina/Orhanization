using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Suppliers.Profiles;

public class SuppliersMappingProfiles : Profile
{
    public SuppliersMappingProfiles()
    {

        //CreateSupplierCommand
        CreateMap<CreatedSupplierResponse, Supplier>().ReverseMap();

        //UpdateSupplierCommand
        CreateMap<UpdatedSupplierResponse, Supplier>().ReverseMap();

        //DeleteSupplierCommand
        CreateMap<DeletedSupplierResponse, Supplier>().ReverseMap();

        //GetByCodeSupplierQuery
        CreateMap<GetByCodeSupplierResponse, Supplier>().ReverseMap();

        //GetByIdSupplierQuery
        CreateMap<GetByIdSupplierResponse, Supplier>().ReverseMap();

        //GetListSupplierQuery
        CreateMap<GetListSupplierListItemDto, Supplier>().ReverseMap();
        CreateMap<Paginate<Supplier>, GetListResponse<GetListSupplierListItemDto>>().ReverseMap();

        //GetListByDynamicSupplierQuery
        CreateMap<GetListByDynamicSupplierListItemDto, Supplier>().ReverseMap();
        CreateMap<Paginate<Supplier>, GetListResponse<GetListByDynamicSupplierListItemDto>>().ReverseMap();

    }
}

