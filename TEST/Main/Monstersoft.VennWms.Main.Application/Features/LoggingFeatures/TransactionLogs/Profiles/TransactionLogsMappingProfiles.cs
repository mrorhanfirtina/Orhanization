using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Profiles;

public class TransactionLogsMappingProfiles : Profile
{
    public TransactionLogsMappingProfiles()
    {

        //CreateTransactionLogCommand
        CreateMap<CreatedTransactionLogResponse, TransactionLog>().ReverseMap();

        //UpdateTransactionLogCommand
        CreateMap<UpdatedTransactionLogResponse, TransactionLog>().ReverseMap();

        //DeleteTransactionLogCommand
        CreateMap<DeletedTransactionLogResponse, TransactionLog>().ReverseMap();

        //GetByIdTransactionLogQuery
        CreateMap<GetByIdTransactionLogResponse, TransactionLog>().ReverseMap();

        //GetListTransactionLogQuery
        CreateMap<GetListTransactionLogListItemDto, TransactionLog>().ReverseMap();
        CreateMap<Paginate<TransactionLog>, GetListResponse<GetListTransactionLogListItemDto>>().ReverseMap();

        //GetListByDynamicTransactionLogQuery
        CreateMap<GetListByDynamicTransactionLogListItemDto, TransactionLog>().ReverseMap();
        CreateMap<Paginate<TransactionLog>, GetListResponse<GetListByDynamicTransactionLogListItemDto>>().ReverseMap();

    }
}
