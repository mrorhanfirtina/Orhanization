using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItems.Dtos.DtoProfiles;

public class ReturnItemDtoMappingProfiles : Profile
{
    public ReturnItemDtoMappingProfiles()
    {
        CreateMap<ReturnItem, CreateReturnItemDto>().ReverseMap();
        CreateMap<ReturnItem, CreateReturnItemSubDto>().ReverseMap();
        CreateMap<ReturnItem, UpdateReturnItemDto>().ReverseMap();
        CreateMap<ReturnItem, UpdateReturnItemSubDto>().ReverseMap();
    }
}
