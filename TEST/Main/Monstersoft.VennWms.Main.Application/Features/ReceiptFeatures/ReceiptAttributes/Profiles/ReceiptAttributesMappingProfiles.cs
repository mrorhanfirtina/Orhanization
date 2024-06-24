using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributes.Profiles;

public class ReceiptAttributesMappingProfiles : Profile
{
    public ReceiptAttributesMappingProfiles()
    {

        //CreateReceiptAttributeCommand
        CreateMap<CreatedReceiptAttributeResponse, ReceiptAttribute>().ReverseMap();

        //UpdateReceiptAttributeCommand
        CreateMap<UpdatedReceiptAttributeResponse, ReceiptAttribute>().ReverseMap();

        //DeleteReceiptAttributeCommand
        CreateMap<DeletedReceiptAttributeResponse, ReceiptAttribute>().ReverseMap();

        //GetByCodeReceiptAttributeQuery
        CreateMap<GetByCodeReceiptAttributeResponse, ReceiptAttribute>().ReverseMap();

        //GetByIdReceiptAttributeQuery
        CreateMap<GetByIdReceiptAttributeResponse, ReceiptAttribute>().ReverseMap();

        //GetListReceiptAttributeQuery
        CreateMap<GetListReceiptAttributeListItemDto, ReceiptAttribute>().ReverseMap();
        CreateMap<Paginate<ReceiptAttribute>, GetListResponse<GetListReceiptAttributeListItemDto>>().ReverseMap();

        //GetListByDynamicReceiptAttributeQuery
        CreateMap<GetListByDynamicReceiptAttributeListItemDto, ReceiptAttribute>().ReverseMap();
        CreateMap<Paginate<ReceiptAttribute>, GetListResponse<GetListByDynamicReceiptAttributeListItemDto>>().ReverseMap();

    }
}

