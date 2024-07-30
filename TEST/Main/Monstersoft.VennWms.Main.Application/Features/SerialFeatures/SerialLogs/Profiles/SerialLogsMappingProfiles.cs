using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Profiles;

public class SerialLogsMappingProfiles : Profile
{
    public SerialLogsMappingProfiles()
    {

        //CreateSerialLogCommand	
        CreateMap<CreatedSerialLogResponse, SerialLog>().ReverseMap();

        //UpdateSerialLogCommand	
        CreateMap<UpdatedSerialLogResponse, SerialLog>().ReverseMap();

        //DeleteSerialLogCommand	
        CreateMap<DeletedSerialLogResponse, SerialLog>().ReverseMap();

        //GetByIdSerialLogQuery	
        CreateMap<GetByIdSerialLogResponse, SerialLog>().ReverseMap();

        //GetListByDynamicSerialLogQuery	
        CreateMap<GetListByDynamicSerialLogListItemDto, SerialLog>().ReverseMap();
        CreateMap<Paginate<SerialLog>, GetListResponse<GetListByDynamicSerialLogListItemDto>>().ReverseMap();

    }
}
