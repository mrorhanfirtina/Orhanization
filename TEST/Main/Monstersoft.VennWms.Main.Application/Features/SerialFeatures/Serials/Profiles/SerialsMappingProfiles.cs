using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Profiles;

public class SerialsMappingProfiles : Profile
{
    public SerialsMappingProfiles()
    {

        //CreateSerialCommand	
        CreateMap<CreatedSerialResponse, Serial>().ReverseMap();

        //UpdateSerialCommand	
        CreateMap<UpdatedSerialResponse, Serial>().ReverseMap();

        //DeleteSerialCommand	
        CreateMap<DeletedSerialResponse, Serial>().ReverseMap();

        //GetByIdSerialQuery	
        CreateMap<GetByIdSerialResponse, Serial>().ReverseMap();

        //GetListByDynamicSerialQuery	
        CreateMap<GetListByDynamicSerialListItemDto, Serial>().ReverseMap();
        CreateMap<Paginate<Serial>, GetListResponse<GetListByDynamicSerialListItemDto>>().ReverseMap();

    }
}
