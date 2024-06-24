using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Profiles;

public class ShipmentMemosMappingProfiles : Profile
{
    public ShipmentMemosMappingProfiles()
    {

        //CreateShipmentMemoCommand
        CreateMap<CreatedShipmentMemoResponse, ShipmentMemo>().ReverseMap();

        //UpdateShipmentMemoCommand
        CreateMap<UpdatedShipmentMemoResponse, ShipmentMemo>().ReverseMap();

        //DeleteShipmentMemoCommand
        CreateMap<DeletedShipmentMemoResponse, ShipmentMemo>().ReverseMap();

        //GetByIdShipmentMemoQuery
        CreateMap<GetByIdShipmentMemoResponse, ShipmentMemo>().ReverseMap();

        //GetListByDynamicShipmentMemoQuery
        CreateMap<GetListByDynamicShipmentMemoListItemDto, ShipmentMemo>().ReverseMap();
        CreateMap<Paginate<ShipmentMemo>, GetListResponse<GetListByDynamicShipmentMemoListItemDto>>().ReverseMap();

    }
}
