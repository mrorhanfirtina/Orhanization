using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.ResponseDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.DtoProfiles;

public class PoTypeDtoMappingProfiles : Profile
{
    public PoTypeDtoMappingProfiles()
    {
        CreateMap<PoType, CreatePoTypeDto>().ReverseMap();
        CreateMap<PoType, UpdatePoTypeDto>().ReverseMap();

        CreateMap<DepositorCompany, PoTypeDepositorCompanyResponseDto>().ReverseMap();
        CreateMap<PurchaseOrder, PoTypePurchaseOrderResponseDto>().ReverseMap();
    }
}
