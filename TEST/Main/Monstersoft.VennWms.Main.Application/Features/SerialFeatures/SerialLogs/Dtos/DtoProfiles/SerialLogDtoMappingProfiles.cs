using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;
using Monstersoft.VennWms.Main.Domain.Entities.SerialEntities;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.DtoProfiles;

public class SerialLogDtoMappingProfiles : Profile
{
    public SerialLogDtoMappingProfiles()
    {
        CreateMap<SerialLog, CreateSerialLogDto>().ReverseMap();
        CreateMap<SerialLog, CreateSerialLogSubDto>().ReverseMap();
        CreateMap<SerialLog, UpdateSerialLogDto>().ReverseMap();
        CreateMap<SerialLog, UpdateSerialLogSubDto>().ReverseMap();

        CreateMap<SerialLogTransactionTypeResponseDto, TransactionType>().ReverseMap();
        CreateMap<SerialLogReceiptResponseDto, Receipt>().ReverseMap();
        CreateMap<SerialLogTransactionLogResponseDto, TransactionLog>().ReverseMap();
        CreateMap<SerialLogDepositorResponseDto, Depositor>().ReverseMap();
        CreateMap<SerialLogDepositorCompanyResponseDto, DepositorCompany>().ReverseMap();
    }
}
