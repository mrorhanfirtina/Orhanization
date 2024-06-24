using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Dtos.DtoProfiles;

public class TransactionTypeDtoMappingProfiles : Profile
{
    public TransactionTypeDtoMappingProfiles()
    {
        CreateMap<TransactionType, CreateTransactionTypeDto>().ReverseMap();
        CreateMap<TransactionType, UpdateTransactionTypeDto>().ReverseMap();
    }
}
