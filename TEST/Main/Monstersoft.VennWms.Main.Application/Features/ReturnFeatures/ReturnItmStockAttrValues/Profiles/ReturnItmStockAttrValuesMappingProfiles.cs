using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItmStockAttrValues.Profiles;

public class ReturnItmStockAttrValuesMappingProfiles : Profile
{
    public ReturnItmStockAttrValuesMappingProfiles()
    {

        //CreateReturnItmStockAttrValueCommand
        CreateMap<CreatedReturnItmStockAttrValueResponse, ReturnItmStockAttrValue>().ReverseMap();

        //UpdateReturnItmStockAttrValueCommand
        CreateMap<UpdatedReturnItmStockAttrValueResponse, ReturnItmStockAttrValue>().ReverseMap();

        //DeleteReturnItmStockAttrValueCommand
        CreateMap<DeletedReturnItmStockAttrValueResponse, ReturnItmStockAttrValue>().ReverseMap();

        //GetByIdReturnItmStockAttrValueQuery
        CreateMap<GetByIdReturnItmStockAttrValueResponse, ReturnItmStockAttrValue>().ReverseMap();

        //GetListByDynamicReturnItmStockAttrValueQuery
        CreateMap<GetListByDynamicReturnItmStockAttrValueListItemDto, ReturnItmStockAttrValue>().ReverseMap();
        CreateMap<Paginate<ReturnItmStockAttrValue>, GetListResponse<GetListByDynamicReturnItmStockAttrValueListItemDto>>().ReverseMap();

    }
}

