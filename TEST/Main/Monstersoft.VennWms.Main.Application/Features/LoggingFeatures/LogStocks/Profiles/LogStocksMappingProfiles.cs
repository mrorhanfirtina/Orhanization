using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Profiles;

public class LogStocksMappingProfiles : Profile
{
    public LogStocksMappingProfiles()
    {

        //CreateLogStockCommand
        CreateMap<CreatedLogStockResponse, LogStock>().ReverseMap();

        //UpdateLogStockCommand
        CreateMap<UpdatedLogStockResponse, LogStock>().ReverseMap();

        //DeleteLogStockCommand
        CreateMap<DeletedLogStockResponse, LogStock>().ReverseMap();


        //GetByIdLogStockQuery
        CreateMap<GetByIdLogStockResponse, LogStock>().ReverseMap();

        //GetListByDynamicLogStockQuery
        CreateMap<GetListByDynamicLogStockListItemDto, LogStock>().ReverseMap();
        CreateMap<Paginate<LogStock>, GetListResponse<GetListByDynamicLogStockListItemDto>>().ReverseMap();

    }
}

