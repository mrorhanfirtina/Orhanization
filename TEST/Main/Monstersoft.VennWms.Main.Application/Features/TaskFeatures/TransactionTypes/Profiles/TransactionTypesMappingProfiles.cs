using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Queries.GetListByDynamic;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Paging;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Profiles;

public class TransactionTypesMappingProfiles : Profile
{
    public TransactionTypesMappingProfiles()
    {

        //CreateTransactionTypeCommand
        CreateMap<CreatedTransactionTypeResponse, TransactionType>().ReverseMap();

        //UpdateTransactionTypeCommand
        CreateMap<UpdatedTransactionTypeResponse, TransactionType>().ReverseMap();

        //DeleteTransactionTypeCommand
        CreateMap<DeletedTransactionTypeResponse, TransactionType>().ReverseMap();

        //GetByCodeTransactionTypeQuery
        CreateMap<GetByCodeTransactionTypeResponse, TransactionType>().ReverseMap();

        //GetByIdTransactionTypeQuery
        CreateMap<GetByIdTransactionTypeResponse, TransactionType>().ReverseMap();

        //GetListTransactionTypeQuery
        CreateMap<GetListTransactionTypeListItemDto, TransactionType>().ReverseMap();
        CreateMap<Paginate<TransactionType>, GetListResponse<GetListTransactionTypeListItemDto>>().ReverseMap();

        //GetListByDynamicTransactionTypeQuery
        CreateMap<GetListByDynamicTransactionTypeListItemDto, TransactionType>().ReverseMap();
        CreateMap<Paginate<TransactionType>, GetListResponse<GetListByDynamicTransactionTypeListItemDto>>().ReverseMap();

    }
}

