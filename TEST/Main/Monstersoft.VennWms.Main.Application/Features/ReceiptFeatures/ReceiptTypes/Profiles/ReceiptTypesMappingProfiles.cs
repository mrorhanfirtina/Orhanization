using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Profiles;

public class ReceiptTypesMappingProfiles : Profile
{
    public ReceiptTypesMappingProfiles()
    {

        //CreateReceiptTypeCommand
        CreateMap<CreatedReceiptTypeResponse, ReceiptType>().ReverseMap();

        //UpdateReceiptTypeCommand
        CreateMap<UpdatedReceiptTypeResponse, ReceiptType>().ReverseMap();

        //DeleteReceiptTypeCommand
        CreateMap<DeletedReceiptTypeResponse, ReceiptType>().ReverseMap();

        //GetByCodeReceiptTypeQuery
        CreateMap<GetByCodeReceiptTypeResponse, ReceiptType>().ReverseMap();

        //GetByIdReceiptTypeQuery
        CreateMap<GetByIdReceiptTypeResponse, ReceiptType>().ReverseMap();

        //GetListReceiptTypeQuery
        CreateMap<GetListReceiptTypeListItemDto, ReceiptType>().ReverseMap();
        CreateMap<Paginate<ReceiptType>, GetListResponse<GetListReceiptTypeListItemDto>>().ReverseMap();

        //GetListByDynamicReceiptTypeQuery
        CreateMap<GetListByDynamicReceiptTypeListItemDto, ReceiptType>().ReverseMap();
        CreateMap<Paginate<ReceiptType>, GetListResponse<GetListByDynamicReceiptTypeListItemDto>>().ReverseMap();

    }
}

