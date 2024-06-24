using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Profiles;

public class ReceiversMappingProfiles : Profile
{
    public ReceiversMappingProfiles()
    {

        //CreateReceiverCommand
        CreateMap<CreatedReceiverResponse, Receiver>().ReverseMap();

        //UpdateReceiverCommand
        CreateMap<UpdatedReceiverResponse, Receiver>().ReverseMap();

        //DeleteReceiverCommand
        CreateMap<DeletedReceiverResponse, Receiver>().ReverseMap();

        //GetByCodeReceiverQuery
        CreateMap<GetByCodeReceiverResponse, Receiver>().ReverseMap();

        //GetByIdReceiverQuery
        CreateMap<GetByIdReceiverResponse, Receiver>().ReverseMap();

        //GetListReceiverQuery
        CreateMap<GetListReceiverListItemDto, Receiver>().ReverseMap();
        CreateMap<Paginate<Receiver>, GetListResponse<GetListReceiverListItemDto>>().ReverseMap();

        //GetListByDynamicReceiverQuery
        CreateMap<GetListByDynamicReceiverListItemDto, Receiver>().ReverseMap();
        CreateMap<Paginate<Receiver>, GetListResponse<GetListByDynamicReceiverListItemDto>>().ReverseMap();

    }
}
