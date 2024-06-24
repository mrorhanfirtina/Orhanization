using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.DtoProfiles;

public class ReceiptTypeDtoMappingProfiles : Profile
{
    public ReceiptTypeDtoMappingProfiles()
    {
        CreateMap<ReceiptType, CreateReceiptTypeDto>().ReverseMap();
        CreateMap<ReceiptType, CreateReceiptTypeSubDto>().ReverseMap();
        CreateMap<ReceiptType, UpdateReceiptTypeDto>().ReverseMap();
        CreateMap<ReceiptType, UpdateReceiptTypeSubDto>().ReverseMap();

        CreateMap<DepositorCompany, ReceiptTypesDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<Receipt, ReceiptTypesReceiptResponseDto>().ReverseMap();
    }
}
