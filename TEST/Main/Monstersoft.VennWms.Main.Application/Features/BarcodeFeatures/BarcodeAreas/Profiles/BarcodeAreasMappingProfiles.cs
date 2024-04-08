using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Profiles;

public class BarcodeAreasMappingProfiles : Profile
{
    public BarcodeAreasMappingProfiles()
    {

        //CreateBarcodeAreaCommand
        CreateMap<CreatedBarcodeAreaResponse, BarcodeArea>().ReverseMap();

        //UpdateBarcodeAreaCommand
        CreateMap<UpdatedBarcodeAreaResponse, BarcodeArea>().ReverseMap();

        //DeleteBarcodeAreaCommand
        CreateMap<DeletedBarcodeAreaResponse, BarcodeArea>().ReverseMap();

        //GetByIdBarcodeAreaQuery
        CreateMap<GetByIdBarcodeAreaResponse, BarcodeArea>().ReverseMap();

        //GetListByBarcodeIdBarcodeAreaQuery
        CreateMap<GetListByDynamicBarcodeAreaListItemDto, BarcodeArea>().ReverseMap();
        CreateMap<Paginate<BarcodeArea>, GetListResponse<GetListByDynamicBarcodeAreaListItemDto>>().ReverseMap();

    }
}

